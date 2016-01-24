using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Critr.Data;

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
  }
}
