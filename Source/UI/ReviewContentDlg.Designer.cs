namespace Critr.UI
{
  partial class ReviewContentDlg
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.uiContent = new System.Windows.Forms.RichTextBox();
      this.uiClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // uiContent
      // 
      this.uiContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiContent.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.uiContent.Location = new System.Drawing.Point(0, 0);
      this.uiContent.Name = "uiContent";
      this.uiContent.ReadOnly = true;
      this.uiContent.Size = new System.Drawing.Size(652, 521);
      this.uiContent.TabIndex = 1;
      this.uiContent.Text = "";
      this.uiContent.WordWrap = false;
      // 
      // uiClose
      // 
      this.uiClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.uiClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.uiClose.Location = new System.Drawing.Point(576, 1);
      this.uiClose.Name = "uiClose";
      this.uiClose.Size = new System.Drawing.Size(75, 23);
      this.uiClose.TabIndex = 0;
      this.uiClose.Text = "Close";
      this.uiClose.UseVisualStyleBackColor = true;
      this.uiClose.Click += new System.EventHandler(this.uiClose_Click);
      // 
      // ReviewContentDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.uiClose;
      this.ClientSize = new System.Drawing.Size(652, 521);
      this.ControlBox = false;
      this.Controls.Add(this.uiClose);
      this.Controls.Add(this.uiContent);
      this.Name = "ReviewContentDlg";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Review Content";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox uiContent;
    private System.Windows.Forms.Button uiClose;
  }
}