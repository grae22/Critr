using System;
using System.Windows.Forms;
using System.Drawing;
using Critr.Utils;
using Critr.Data;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace Critr.UI
{
  public partial class ReviewContentDlg : Form
  {
    //-------------------------------------------------------------------------

    private HtmlPanel _uiContent = new HtmlPanel();

    //-------------------------------------------------------------------------

    public ReviewContentDlg( string filePath,
                             int revision )
    {
      InitializeComponent();

      // Add file path to the dlg title.
      Text += ": " + filePath + '#' + revision;

      // Add the html renderer component.
      _uiContent.Dock = DockStyle.Fill;
      _uiContent.Text = ReviewItem.GetHtmlDiffContent( filePath, revision );
      Controls.Add( _uiContent );

      uiClose.SendToBack();
    }

    //-------------------------------------------------------------------------

    private void uiClose_Click( object sender, EventArgs e )
    {
      Close();
    }

    //-------------------------------------------------------------------------
  }
}
