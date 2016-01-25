using System;
using System.Collections.Generic;
using Critr.Utils;

namespace Critr.Data
{
  public class ReviewItem
  {
    //-------------------------------------------------------------------------

    // Processes diff content produced using "p4 diff2 -du file1 file2".

    public static string GetRichTextFormattedDiffContent(
      string p4filePath,
      int revision )
    {
      string richText = "";

      // Get the complete prev revision.
      string prevContent =
        Perforce.RunCommand(
          "print -q " + p4filePath + '#' + ( ( revision > 0 ) ? revision - 1 : revision ) );

      string[] tmpPrevContentLines =
        prevContent.Split( new string[] { Environment.NewLine }, StringSplitOptions.None );

      List<string> prevContentLines = new List<string>();
      foreach( string line in tmpPrevContentLines )
      {
        prevContentLines.Add( line );
      }
      
      // Perform the diff.
      string diffContent =
        Perforce.RunCommand(
          "diff2 -du " +
            p4filePath + '#' + ( revision - 1 ) + ' ' +
            p4filePath + '#' + revision );

      string[] lines =
        diffContent.Split( new string[] { Environment.NewLine }, StringSplitOptions.None );

      int insertPoint = 0;
      int linesAdded = 0;

      foreach( string line in lines )
      {
        // Skip the header.
        if( line.IndexOf( "====" ) == 0 )
        {
          continue;
        }

        // Is this line the beginning of a diff section?
        if( line.IndexOf( "@@" ) == 0 )
        {
          // Get the line number that the diff applies to.
          string tmp = line.Remove( 0, 4 );
          string lineNumberStr = tmp.Substring( 0, tmp.IndexOf( ',' ) );

          if( int.TryParse( lineNumberStr, out insertPoint ) == false )
          {
            throw new Exception( "Failed to extract line number from diff." );
          }

          // Translate insert-point from range start at 1 to range starting at 0.
          insertPoint--;

          insertPoint += linesAdded;

          continue;
        }

        if( line.Length == 0 )
        {
          insertPoint++;
          continue;
        }
        // Content was added.
        else if( line[ 0 ] == '+' )
        {
          if( insertPoint > prevContentLines.Count )
          {
            throw new Exception( "Insert-point is out-of-bounds." );
          }

          prevContentLines.Insert( insertPoint, line );
          linesAdded++;
        }
        // Content was removed.
        else if( line[ 0 ] == '-' )
        {
          if( insertPoint > prevContentLines.Count )
          {
            throw new Exception( "Insert-point is out-of-bounds." );
          }

          prevContentLines.RemoveAt( insertPoint );
          prevContentLines.Insert( insertPoint, line );
        }

        insertPoint++;
      }

      int lineNumber = 1;
      string lineNumberFormat = "";
      for( int i = 0; i < prevContentLines.Count.ToString().Length; i++ )
      {
        lineNumberFormat += '0';
      }

      foreach( string line in prevContentLines )
      {
        richText +=
          lineNumber.ToString( lineNumberFormat ) + " | " + line + Environment.NewLine;

        lineNumber++;
      }

      return richText;
    }

    //=========================================================================

    public int Id { get; private set; }
    public bool Active { get; set; }
    public User CreatedByUser { get; set; }
    public DateTime Timestamp { get; set; }
    public Changelist Changelist { get; set; }
    public string FilePath { get; set; }
    public int FileRevision { get; set; }
    public string Content { get; set; }

    //-------------------------------------------------------------------------

    public ReviewItem()
    {
      Id = -1;
      Active = false;
      CreatedByUser = null;
      Timestamp = DateTime.Now;
      Changelist = null;
      FilePath = "";
      FileRevision = -1;
      Content = "";
    }

    //-------------------------------------------------------------------------
  }
}
