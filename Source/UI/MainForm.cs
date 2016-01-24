using System;
using System.Windows.Forms;
using Critr.Data;

namespace Critr.UI
{
  public partial class MainForm : Form
  {
    //-------------------------------------------------------------------------

    public MainForm()
    {
      InitializeComponent();
    }

    //-------------------------------------------------------------------------

    private void MainForm_Load( object sender, EventArgs e )
    {
      // Who did we last login as?
      string lastUsername = 
        Program.Settings.GetSetting<string>( "App.LastUser", null, false );

      User lastUser = Program.UserCollection.GetUser( lastUsername );

      // Show user dialog so user can logon.
      UserDetailsDlg dlg = new UserDetailsDlg();
      dlg.SelectedUser = lastUser;
      dlg.ShowDialog( this );

      // Change the logged in user.
      Program.LoggedOnUser = dlg.SelectedUser;

      // Save selection to settings.
      Program.Settings.SetSetting<string>(
        "App.LastUser",
        Program.LoggedOnUser == null ? "" : Program.LoggedOnUser.Username,
        false );

      // Update the form title with the username.
      if( Program.LoggedOnUser != null )
      {
        Text += " (User: " + Program.LoggedOnUser.Username + ')';
      }
      else
      {
        Text += " (No User)";
      }

      // Clean up.
      dlg.Close();

      // Apply user permissions.
      ApplyUserPermissions();
    }

    //-------------------------------------------------------------------------

    private void ApplyUserPermissions()
    {
      uiNewReview.Enabled =
        Program.LoggedOnUser != null &&
        Program.LoggedOnUser.IsReviewCreator;
    }

    //-------------------------------------------------------------------------

    private void uiNewReview_Click( object sender, EventArgs e )
    {
      ReviewDlg dlg = new ReviewDlg( null );
      dlg.ShowDialog( this );
      dlg.Dispose();
    }

    //-------------------------------------------------------------------------
  }
}
