using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Critr.Data;
using Critr.Utils;

namespace Critr.UI
{
  public partial class SelectChangelist : Form
  {
    //-------------------------------------------------------------------------

    public Changelist SelectedChangelist { get; private set; }

    //-------------------------------------------------------------------------

    public SelectChangelist( Changelist changelist )
    {
      SelectedChangelist = changelist;

      InitializeComponent();
    }

    //-------------------------------------------------------------------------

    private void SelectChangelist_Load( object sender, EventArgs e )
    {
      // If we have a changelist, change the date pickers to its date.
      if( SelectedChangelist != null )
      {
        uiFromDate.Value = SelectedChangelist.SubmittedDate;
        uiToDate.Value = SelectedChangelist.SubmittedDate;
      }
      else  // No changelist, so use today and the prev week.
      {
        uiFromDate.Value = DateTime.Now.AddDays( -7 );
        uiToDate.Value = DateTime.Now;
      }

      PopulateChangelists();
      uiChangelists_SelectedIndexChanged( null, null );
    }

    //-------------------------------------------------------------------------

    private void uiFromDate_ValueChanged( object sender, EventArgs e )
    {
      // 'To' date is now after the 'For' date?
      if( uiToDate.Value < uiFromDate.Value )
      {
        uiToDate.Value = uiFromDate.Value;
      }

      PopulateChangelists();
    }

    //-------------------------------------------------------------------------

    private void uiToDate_ValueChanged( object sender, EventArgs e )
    {
      // 'From' date is now after the 'To' date?
      if( uiFromDate.Value > uiToDate.Value )
      {
        uiFromDate.Value = uiToDate.Value;
      }

      PopulateChangelists();
    }

    //-------------------------------------------------------------------------

    private void PopulateChangelists()
    {
      uiChangelists.Items.Clear();

      List<Changelist> changelists = new List<Changelist>();

      ChangelistHelpers.GetChangelistsFromP4(
        uiFromDate.Value,
        uiToDate.Value,
        ref changelists );

      foreach( Changelist changelist in changelists )
      {
        uiChangelists.Items.Add( changelist );
      }
    }

    //-------------------------------------------------------------------------

    private void uiChangelists_SelectedIndexChanged( object sender, EventArgs e )
    {
      // Reset form section.
      uiChangelistFiles.Items.Clear();

      uiChangelistNumber.Text = "";
      uiChangelistUser.Text = "";
      uiChangelistDate.Text = "";

      // Get the selected changelist.
      Changelist changelist = uiChangelists.SelectedItem as Changelist;

      if( changelist == null )
      {
        return;
      }

      uiChangelistNumber.Text = changelist.Id.ToString();
      uiChangelistUser.Text = changelist.Submitter.Username;
      uiChangelistDate.Text = changelist.SubmittedDate.ToString( "yyyy/MM/dd" );

      //-- Get changelist's files from P4.
      string output = Perforce.RunCommand( "describe -s " + changelist.Id );

      // Exract files from output.
      int index = output.IndexOf( "Affected files ..." );

      while( ( index = output.IndexOf( "... ", index + 1 ) ) > -1 )
      {
        // Skip the "... " prefixing the path.
        index += 4;

        // Grab the path from between the ellipses and the revision.
        int revisionIndex = output.IndexOf( ' ', index );

        if( revisionIndex < 0 )
        {
          continue;
        }

        string path = output.Substring( index, revisionIndex - index );

        // Add file path to the ui list.
        uiChangelistFiles.Items.Add( path );
      }
    }

    //-------------------------------------------------------------------------

    private void uiChangelistFiles_SelectedIndexChanged( object sender, EventArgs e )
    {
      if( uiChangelistFiles.SelectedItem == null )
      {
        return;
      }

      string path = uiChangelistFiles.SelectedItem as string;
      int revIndex = path.LastIndexOf( '#' ) + 1;
      string revStr = path.Substring( revIndex, path.Length - revIndex );
      int rev = 0;

      if( int.TryParse( revStr, out rev ) == false )
      {
        return;
      }

      path = path.Remove( revIndex - 1 );

      ReviewContentDlg dlg = new ReviewContentDlg( path, rev );
      dlg.ShowDialog( this );
    }

    //-------------------------------------------------------------------------
  }
}
