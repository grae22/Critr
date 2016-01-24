using System;
using System.Windows.Forms;
using Critr.Data;

namespace Critr.UI
{
  public partial class ReviewDlg : Form
  {
    //-------------------------------------------------------------------------

    public ReviewItem Review { get; private set; }

    //-------------------------------------------------------------------------

    public ReviewDlg( ReviewItem reviewItem )
    {
      InitializeComponent();

      // There must be a logged on user.
      if( Program.LoggedOnUser == null )
      {
        throw new Exception( "No user logged-on." );
      }

      // Null review item given? We're creating a new item.
      Review = reviewItem;

      if( reviewItem == null )
      {
        Review = new ReviewItem();
        Review.Active = true;
        Review.CreatedByUser = Program.LoggedOnUser;
      }
    }

    //-------------------------------------------------------------------------

    private void ReviewDlg_Load( object sender, EventArgs e )
    {
      PopulateForm();
    }

    //-------------------------------------------------------------------------

    private void PopulateForm()
    {
      // Id.
      uiId.Text = "Pending";

      if( Review.Id > -1 )
      {
        uiId.Text = Review.Id.ToString();
      }

      // General Review fields.
      uiCreatedBy.Text = Review.CreatedByUser.Username;
      uiCreatedDate.Text = Review.Timestamp.ToString( "yyyy/MM/dd hh:mm" );
      uiActive.Checked = Review.Active;

      // Changelist.
      Changelist changelist = Review.Changelist;

      if( changelist != null )
      {
        // User.
        if( changelist.Submitter == null )
        {
          uiChangelistUser.Text = "UNKNOWN";
        }
        else
        {
          uiChangelistUser.Text = changelist.Submitter.Username;
        }

        // General.
        uiChangelist.Text = ( changelist.Id > -1 ? changelist.Id.ToString() : "" );
        uiSubmittedDate.Text = changelist.SubmittedDate.ToString( "yyyy/MM/dd hh:mm" );
        uiChangelistDescription.Text = changelist.Description;
        uiFile.Text = Review.FilePath;
        uiFileRevision.Text = Review.FileRevision.ToString();
      }
      else
      {
        uiChangelistUser.Text = "";
        uiChangelist.Text = "";
        uiSubmittedDate.Text = "";
        uiChangelistDescription.Text = "";
        uiFile.Text = "";
        uiFileRevision.Text = "";
      }
    }

    //-------------------------------------------------------------------------

    private void uiSelectChangelist_Click( object sender, EventArgs e )
    {
      SelectChangelist dlg = new SelectChangelist( null );
      dlg.ShowDialog( this );
      dlg.Close();
    }

    //-------------------------------------------------------------------------
  }
}
