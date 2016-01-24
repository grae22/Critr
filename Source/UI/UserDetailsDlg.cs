using System;
using System.Windows.Forms;
using Critr.Data;

namespace Critr.UI
{
  public partial class UserDetailsDlg : Form
  {
    //-------------------------------------------------------------------------

    public User SelectedUser { get; set; }

    //-------------------------------------------------------------------------

    public UserDetailsDlg()
    {
      InitializeComponent();
    }

    //-------------------------------------------------------------------------

    private void UserDetailsDlg_Load( object sender, EventArgs e )
    {
      PopulateUsernames();
      uiP4Username.SelectedItem = SelectedUser;
    }

    //-------------------------------------------------------------------------

    private void PopulateUsernames()
    {
      uiP4Username.Items.Clear();

      foreach( User user in Program.UserCollection.Users )
      {
        uiP4Username.Items.Add( user );
      }
    }

    //-------------------------------------------------------------------------

    private void uiOK_Click( object sender, EventArgs e )
    {
      // Nothing selected? Do nothing.
      if( uiP4Username.SelectedItem == null )
      {
        return;
      }

      SelectedUser = uiP4Username.SelectedItem as User;

      Hide();
    }

    //-------------------------------------------------------------------------

    private void uiCancel_Click( object sender, EventArgs e )
    {
      SelectedUser = null;

      Hide();
    }

    //-------------------------------------------------------------------------
  }
}
