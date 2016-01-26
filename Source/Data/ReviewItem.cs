using System;
using System.Collections.Generic;
using Critr.Utils;

namespace Critr.Data
{
  public class ReviewItem
  {
    //-------------------------------------------------------------------------

    private const string c_changeColour_addition = "#aaffaa";
    private const string c_changeColour_subtraction = "#ffaaaa";

    //-------------------------------------------------------------------------

    // Processes diff content produced using "p4 diff2 -du file1 file2".

    public static string GetHtmlDiffContent(
      string p4filePath,
      int revision )
    {
      //-- Get the complete prev revision.
      string prevContent =
        Perforce.RunCommand(
          "print -q " + p4filePath + '#' + ( ( revision > 0 ) ? revision - 1 : revision ) );

      // Make it html safe (replace the angle brackets).
      prevContent = prevContent.Replace( "<", "&lt;" );
      prevContent = prevContent.Replace( ">", "&gt;" );

      // Split into individual lines.
      string[] tmpPrevContentLines =
        prevContent.Split( new string[] { Environment.NewLine }, StringSplitOptions.None );

      List<string> prevContentLines = new List<string>();
      foreach( string line in tmpPrevContentLines )
      {
        prevContentLines.Add( line );
      }

      //-- Perform the diff.
      string diffContent =
        Perforce.RunCommand(
          "diff2 -du " +
            p4filePath + '#' + ( revision - 1 ) + ' ' +
            p4filePath + '#' + revision );

      // Make HTML safe (replace the angle brackets).
      diffContent = diffContent.Replace( "<", "&lt;" );
      diffContent = diffContent.Replace( ">", "&gt;" );

      string[] lines =
        diffContent.Split( new string[] { Environment.NewLine }, StringSplitOptions.None );

      // Iterate through the diff's lines, applying changes to the previous revision as we go.
      int insertPoint = 0;
      int linesAdded = 0;

      foreach( string line in lines )
      {
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

        if( line.Length > 0 )
        {
          // Content was added.
          if( line[ 0 ] == '+' )
          {
            if( insertPoint > prevContentLines.Count )
            {
              throw new Exception( "Insert-point is out-of-bounds." );
            }

            string tmp = line.Remove( 0, 1 );
            
            prevContentLines.Insert(
              insertPoint, "<font bgcolor='" + c_changeColour_addition + "'>" + tmp + "</font>" );
            
            linesAdded++;
          }
          // Content was removed.
          else if( line[ 0 ] == '-' )
          {
            if( insertPoint > prevContentLines.Count )
            {
              throw new Exception( "Insert-point is out-of-bounds." );
            }

            string tmp = line.Remove( 0, 1 );
            while( tmp.Length < 80 )
            {
              tmp += ' ';
            }

            prevContentLines.RemoveAt( insertPoint );
            prevContentLines.Insert( insertPoint, "<font bgcolor='" + c_changeColour_subtraction + "'>" + tmp + "</font>" );
          }

          insertPoint++;
        }
      }

      // Create a line-number format string - we want to pad the line number
      // with enough zeroes so all line numbers in this file have the same
      // number of digits.
      int lineNumber = 1;
      string lineNumberFormat = "";
      for( int i = 0; i < prevContentLines.Count.ToString().Length; i++ )
      {
        lineNumberFormat += '0';
      }

      // Create html.
      string html =
        "<html>" + Environment.NewLine +
        "<head></head>" + Environment.NewLine +
        "<body>" + Environment.NewLine;

      foreach( string line in prevContentLines )
      {
        // TODO: Line numbering is wrong.
        html +=
          /*lineNumber.ToString( lineNumberFormat ) +*/ "&nbsp;|&nbsp;" + line + "<br />" + Environment.NewLine;

        lineNumber++;
      }

      html += Environment.NewLine + "</body>" + Environment.NewLine + "</html>";

      // Highlight tab chars.
      // TODO: This doesn't seem to work.
      html = html.Replace( "" + System.Windows.Forms.Keys.Tab, "<font bgcolor='red'>_</font>" );

      // Replace spaces with '@nbsp;' (exclude tags).
      string htmlCopy = html;
      bool isAngleBrackOpen = false;
      int htmlOffset = 0;

      for( int i = 0; i < htmlCopy.Length; i++ )
      {
        if( htmlCopy[ i ] == '<' )
        {
          isAngleBrackOpen = true;
        }
        else if( htmlCopy[ i ] == '>' )
        {
          isAngleBrackOpen = false;
        }
        else if( htmlCopy[ i ] == ' ' &&
                 isAngleBrackOpen == false )
        {
          html = html.Remove( htmlOffset, 1 );
          html = html.Insert( htmlOffset, "&nbsp;" );
          htmlOffset += "&nbsp;".Length;
          continue;
        }

        htmlOffset++;
      }

      html =
        html.Insert(
          html.IndexOf( "</head>" ),
          "<style>body { white-space: pre; font-family: Courier New; font-size: 100%; }</style>" );

      return html;
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
