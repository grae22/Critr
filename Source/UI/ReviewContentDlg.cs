using System;
using System.Windows.Forms;
using Critr.Utils;
using Critr.Data;

namespace Critr.UI
{
  public partial class ReviewContentDlg : Form
  {
    //-------------------------------------------------------------------------

    public ReviewContentDlg( string filePath,
                             int revision )
    {
      InitializeComponent();

      uiContent.Text =
        ReviewItem.GetRichTextFormattedDiffContent( filePath, revision );
    }

    //-------------------------------------------------------------------------

    private void uiClose_Click( object sender, EventArgs e )
    {
      Close();
    }

    //-------------------------------------------------------------------------
  }
}
