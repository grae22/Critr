using System;
using System.Windows.Forms;
using Critr.Utils;

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
        Perforce.RunCommand(
          "diff2 -u " +
            filePath + '#' + ( revision - 1 ) + ' ' +
            filePath + '#' + revision );
    }

    //-------------------------------------------------------------------------

    private void uiClose_Click( object sender, EventArgs e )
    {
      Close();
    }

    //-------------------------------------------------------------------------
  }
}
