namespace Critr.UI
{
  partial class MainForm
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
      this.uiMenuStrip = new System.Windows.Forms.MenuStrip();
      this.uiReviewsMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.uiNewReview = new System.Windows.Forms.ToolStripMenuItem();
      this.uiMainPanel = new System.Windows.Forms.Panel();
      this.uiSplit1 = new System.Windows.Forms.SplitContainer();
      this.uiSplit1_1 = new System.Windows.Forms.SplitContainer();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.uiReviews = new System.Windows.Forms.ListBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.uiComments = new System.Windows.Forms.ListBox();
      this.uiSplit1_2 = new System.Windows.Forms.SplitContainer();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.uiReviewContent = new System.Windows.Forms.RichTextBox();
      this.uiSplit2_1 = new System.Windows.Forms.SplitContainer();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.uiComment = new System.Windows.Forms.TextBox();
      this.uiSplit2_3 = new System.Windows.Forms.SplitContainer();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.uiMenuStrip.SuspendLayout();
      this.uiMainPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit1)).BeginInit();
      this.uiSplit1.Panel1.SuspendLayout();
      this.uiSplit1.Panel2.SuspendLayout();
      this.uiSplit1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit1_1)).BeginInit();
      this.uiSplit1_1.Panel1.SuspendLayout();
      this.uiSplit1_1.Panel2.SuspendLayout();
      this.uiSplit1_1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit1_2)).BeginInit();
      this.uiSplit1_2.Panel1.SuspendLayout();
      this.uiSplit1_2.Panel2.SuspendLayout();
      this.uiSplit1_2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit2_1)).BeginInit();
      this.uiSplit2_1.Panel1.SuspendLayout();
      this.uiSplit2_1.Panel2.SuspendLayout();
      this.uiSplit2_1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit2_3)).BeginInit();
      this.uiSplit2_3.Panel1.SuspendLayout();
      this.uiSplit2_3.Panel2.SuspendLayout();
      this.uiSplit2_3.SuspendLayout();
      this.SuspendLayout();
      // 
      // uiMenuStrip
      // 
      this.uiMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiReviewsMenu});
      this.uiMenuStrip.Location = new System.Drawing.Point(4, 0);
      this.uiMenuStrip.Name = "uiMenuStrip";
      this.uiMenuStrip.Size = new System.Drawing.Size(1011, 24);
      this.uiMenuStrip.TabIndex = 0;
      this.uiMenuStrip.Text = "menuStrip1";
      // 
      // uiReviewsMenu
      // 
      this.uiReviewsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiNewReview});
      this.uiReviewsMenu.Name = "uiReviewsMenu";
      this.uiReviewsMenu.Size = new System.Drawing.Size(59, 20);
      this.uiReviewsMenu.Text = "&Reviews";
      // 
      // uiNewReview
      // 
      this.uiNewReview.Name = "uiNewReview";
      this.uiNewReview.Size = new System.Drawing.Size(95, 22);
      this.uiNewReview.Text = "&New";
      this.uiNewReview.Click += new System.EventHandler(this.uiNewReview_Click);
      // 
      // uiMainPanel
      // 
      this.uiMainPanel.Controls.Add(this.uiSplit1);
      this.uiMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiMainPanel.Location = new System.Drawing.Point(4, 24);
      this.uiMainPanel.Name = "uiMainPanel";
      this.uiMainPanel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
      this.uiMainPanel.Size = new System.Drawing.Size(1011, 578);
      this.uiMainPanel.TabIndex = 1;
      // 
      // uiSplit1
      // 
      this.uiSplit1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiSplit1.Location = new System.Drawing.Point(0, 4);
      this.uiSplit1.Name = "uiSplit1";
      // 
      // uiSplit1.Panel1
      // 
      this.uiSplit1.Panel1.Controls.Add(this.uiSplit1_1);
      // 
      // uiSplit1.Panel2
      // 
      this.uiSplit1.Panel2.Controls.Add(this.uiSplit1_2);
      this.uiSplit1.Size = new System.Drawing.Size(1011, 574);
      this.uiSplit1.SplitterDistance = 198;
      this.uiSplit1.TabIndex = 2;
      // 
      // uiSplit1_1
      // 
      this.uiSplit1_1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiSplit1_1.Location = new System.Drawing.Point(0, 0);
      this.uiSplit1_1.Name = "uiSplit1_1";
      this.uiSplit1_1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // uiSplit1_1.Panel1
      // 
      this.uiSplit1_1.Panel1.Controls.Add(this.groupBox1);
      // 
      // uiSplit1_1.Panel2
      // 
      this.uiSplit1_1.Panel2.Controls.Add(this.groupBox2);
      this.uiSplit1_1.Size = new System.Drawing.Size(198, 574);
      this.uiSplit1_1.SplitterDistance = 233;
      this.uiSplit1_1.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uiReviews);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
      this.groupBox1.Size = new System.Drawing.Size(198, 233);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Reviews:";
      // 
      // uiReviews
      // 
      this.uiReviews.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiReviews.FormattingEnabled = true;
      this.uiReviews.Location = new System.Drawing.Point(8, 21);
      this.uiReviews.Name = "uiReviews";
      this.uiReviews.Size = new System.Drawing.Size(182, 204);
      this.uiReviews.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.uiComments);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
      this.groupBox2.Size = new System.Drawing.Size(198, 337);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Review Comments:";
      // 
      // uiComments
      // 
      this.uiComments.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiComments.FormattingEnabled = true;
      this.uiComments.Location = new System.Drawing.Point(8, 21);
      this.uiComments.Name = "uiComments";
      this.uiComments.Size = new System.Drawing.Size(182, 308);
      this.uiComments.TabIndex = 1;
      // 
      // uiSplit1_2
      // 
      this.uiSplit1_2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiSplit1_2.Location = new System.Drawing.Point(0, 0);
      this.uiSplit1_2.Name = "uiSplit1_2";
      // 
      // uiSplit1_2.Panel1
      // 
      this.uiSplit1_2.Panel1.Controls.Add(this.groupBox3);
      // 
      // uiSplit1_2.Panel2
      // 
      this.uiSplit1_2.Panel2.Controls.Add(this.uiSplit2_1);
      this.uiSplit1_2.Size = new System.Drawing.Size(809, 574);
      this.uiSplit1_2.SplitterDistance = 504;
      this.uiSplit1_2.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.uiReviewContent);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox3.Location = new System.Drawing.Point(0, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(8);
      this.groupBox3.Size = new System.Drawing.Size(504, 574);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Review Content:";
      // 
      // uiReviewContent
      // 
      this.uiReviewContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.uiReviewContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiReviewContent.Location = new System.Drawing.Point(8, 21);
      this.uiReviewContent.Name = "uiReviewContent";
      this.uiReviewContent.Size = new System.Drawing.Size(488, 545);
      this.uiReviewContent.TabIndex = 1;
      this.uiReviewContent.Text = "";
      // 
      // uiSplit2_1
      // 
      this.uiSplit2_1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiSplit2_1.Location = new System.Drawing.Point(0, 0);
      this.uiSplit2_1.Name = "uiSplit2_1";
      this.uiSplit2_1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // uiSplit2_1.Panel1
      // 
      this.uiSplit2_1.Panel1.Controls.Add(this.groupBox4);
      // 
      // uiSplit2_1.Panel2
      // 
      this.uiSplit2_1.Panel2.Controls.Add(this.uiSplit2_3);
      this.uiSplit2_1.Size = new System.Drawing.Size(301, 574);
      this.uiSplit2_1.SplitterDistance = 156;
      this.uiSplit2_1.TabIndex = 0;
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.uiComment);
      this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox4.Location = new System.Drawing.Point(0, 0);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new System.Windows.Forms.Padding(8);
      this.groupBox4.Size = new System.Drawing.Size(301, 156);
      this.groupBox4.TabIndex = 0;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Comment:";
      // 
      // uiComment
      // 
      this.uiComment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiComment.Location = new System.Drawing.Point(8, 21);
      this.uiComment.Multiline = true;
      this.uiComment.Name = "uiComment";
      this.uiComment.ReadOnly = true;
      this.uiComment.Size = new System.Drawing.Size(285, 127);
      this.uiComment.TabIndex = 0;
      // 
      // uiSplit2_3
      // 
      this.uiSplit2_3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiSplit2_3.Location = new System.Drawing.Point(0, 0);
      this.uiSplit2_3.Name = "uiSplit2_3";
      this.uiSplit2_3.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // uiSplit2_3.Panel1
      // 
      this.uiSplit2_3.Panel1.Controls.Add(this.groupBox5);
      // 
      // uiSplit2_3.Panel2
      // 
      this.uiSplit2_3.Panel2.Controls.Add(this.groupBox6);
      this.uiSplit2_3.Size = new System.Drawing.Size(301, 414);
      this.uiSplit2_3.SplitterDistance = 195;
      this.uiSplit2_3.TabIndex = 0;
      // 
      // groupBox5
      // 
      this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox5.Location = new System.Drawing.Point(0, 0);
      this.groupBox5.Margin = new System.Windows.Forms.Padding(8);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Padding = new System.Windows.Forms.Padding(8);
      this.groupBox5.Size = new System.Drawing.Size(301, 195);
      this.groupBox5.TabIndex = 1;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Metrics (pertaining to the current comment):";
      // 
      // groupBox6
      // 
      this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox6.Location = new System.Drawing.Point(0, 0);
      this.groupBox6.Margin = new System.Windows.Forms.Padding(8);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Padding = new System.Windows.Forms.Padding(8);
      this.groupBox6.Size = new System.Drawing.Size(301, 215);
      this.groupBox6.TabIndex = 2;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Metrics (pertaining to the review in general):";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1019, 606);
      this.Controls.Add(this.uiMainPanel);
      this.Controls.Add(this.uiMenuStrip);
      this.MainMenuStrip = this.uiMenuStrip;
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Critr";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.uiMenuStrip.ResumeLayout(false);
      this.uiMenuStrip.PerformLayout();
      this.uiMainPanel.ResumeLayout(false);
      this.uiSplit1.Panel1.ResumeLayout(false);
      this.uiSplit1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit1)).EndInit();
      this.uiSplit1.ResumeLayout(false);
      this.uiSplit1_1.Panel1.ResumeLayout(false);
      this.uiSplit1_1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit1_1)).EndInit();
      this.uiSplit1_1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.uiSplit1_2.Panel1.ResumeLayout(false);
      this.uiSplit1_2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit1_2)).EndInit();
      this.uiSplit1_2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.uiSplit2_1.Panel1.ResumeLayout(false);
      this.uiSplit2_1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit2_1)).EndInit();
      this.uiSplit2_1.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.uiSplit2_3.Panel1.ResumeLayout(false);
      this.uiSplit2_3.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.uiSplit2_3)).EndInit();
      this.uiSplit2_3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip uiMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem uiReviewsMenu;
    private System.Windows.Forms.ToolStripMenuItem uiNewReview;
    private System.Windows.Forms.Panel uiMainPanel;
    private System.Windows.Forms.SplitContainer uiSplit1;
    private System.Windows.Forms.SplitContainer uiSplit1_1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox uiReviews;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListBox uiComments;
    private System.Windows.Forms.SplitContainer uiSplit1_2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.RichTextBox uiReviewContent;
    private System.Windows.Forms.SplitContainer uiSplit2_1;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox uiComment;
    private System.Windows.Forms.SplitContainer uiSplit2_3;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.GroupBox groupBox6;
  }
}