namespace Critr.UI
{
  partial class SelectChangelist
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.uiHideRecentlyReviewedUsers = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiToDate = new System.Windows.Forms.DateTimePicker();
      this.uiFromDate = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.uiChangelists = new System.Windows.Forms.ListBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.uiChangelistFiles = new System.Windows.Forms.ListBox();
      this.uiChangelistDate = new System.Windows.Forms.Label();
      this.uiChangelistUser = new System.Windows.Forms.Label();
      this.uiChangelistNumber = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uiHideRecentlyReviewedUsers);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.uiToDate);
      this.groupBox1.Controls.Add(this.uiFromDate);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(532, 66);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Filters:";
      // 
      // uiHideRecentlyReviewedUsers
      // 
      this.uiHideRecentlyReviewedUsers.AutoSize = true;
      this.uiHideRecentlyReviewedUsers.Checked = true;
      this.uiHideRecentlyReviewedUsers.CheckState = System.Windows.Forms.CheckState.Checked;
      this.uiHideRecentlyReviewedUsers.Location = new System.Drawing.Point(346, 29);
      this.uiHideRecentlyReviewedUsers.Name = "uiHideRecentlyReviewedUsers";
      this.uiHideRecentlyReviewedUsers.Size = new System.Drawing.Size(165, 17);
      this.uiHideRecentlyReviewedUsers.TabIndex = 3;
      this.uiHideRecentlyReviewedUsers.Text = "Hide recently reviewed users.";
      this.uiHideRecentlyReviewedUsers.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(152, 30);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(16, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "to";
      // 
      // uiToDate
      // 
      this.uiToDate.CustomFormat = "yyyy/MM/dd";
      this.uiToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.uiToDate.Location = new System.Drawing.Point(174, 26);
      this.uiToDate.Name = "uiToDate";
      this.uiToDate.Size = new System.Drawing.Size(92, 20);
      this.uiToDate.TabIndex = 2;
      this.uiToDate.ValueChanged += new System.EventHandler(this.uiToDate_ValueChanged);
      // 
      // uiFromDate
      // 
      this.uiFromDate.CustomFormat = "yyyy/MM/dd";
      this.uiFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.uiFromDate.Location = new System.Drawing.Point(54, 26);
      this.uiFromDate.Name = "uiFromDate";
      this.uiFromDate.Size = new System.Drawing.Size(92, 20);
      this.uiFromDate.TabIndex = 1;
      this.uiFromDate.ValueChanged += new System.EventHandler(this.uiFromDate_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Date:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.uiChangelists);
      this.groupBox2.Location = new System.Drawing.Point(12, 84);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
      this.groupBox2.Size = new System.Drawing.Size(532, 222);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Changelists:";
      // 
      // uiChangelists
      // 
      this.uiChangelists.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiChangelists.FormattingEnabled = true;
      this.uiChangelists.Location = new System.Drawing.Point(8, 21);
      this.uiChangelists.Name = "uiChangelists";
      this.uiChangelists.Size = new System.Drawing.Size(516, 193);
      this.uiChangelists.TabIndex = 7;
      this.uiChangelists.SelectedIndexChanged += new System.EventHandler(this.uiChangelists_SelectedIndexChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.uiChangelistFiles);
      this.groupBox3.Controls.Add(this.uiChangelistDate);
      this.groupBox3.Controls.Add(this.uiChangelistUser);
      this.groupBox3.Controls.Add(this.uiChangelistNumber);
      this.groupBox3.Controls.Add(this.label5);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Location = new System.Drawing.Point(12, 312);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(532, 188);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Selected Changelist:";
      // 
      // uiChangelistFiles
      // 
      this.uiChangelistFiles.FormattingEnabled = true;
      this.uiChangelistFiles.HorizontalScrollbar = true;
      this.uiChangelistFiles.Location = new System.Drawing.Point(18, 61);
      this.uiChangelistFiles.Name = "uiChangelistFiles";
      this.uiChangelistFiles.Size = new System.Drawing.Size(493, 108);
      this.uiChangelistFiles.TabIndex = 6;
      this.uiChangelistFiles.SelectedIndexChanged += new System.EventHandler(this.uiChangelistFiles_SelectedIndexChanged);
      // 
      // uiChangelistDate
      // 
      this.uiChangelistDate.AutoSize = true;
      this.uiChangelistDate.ForeColor = System.Drawing.Color.Navy;
      this.uiChangelistDate.Location = new System.Drawing.Point(346, 30);
      this.uiChangelistDate.Name = "uiChangelistDate";
      this.uiChangelistDate.Size = new System.Drawing.Size(95, 13);
      this.uiChangelistDate.TabIndex = 5;
      this.uiChangelistDate.Text = "2016/01/01 12:59";
      // 
      // uiChangelistUser
      // 
      this.uiChangelistUser.AutoSize = true;
      this.uiChangelistUser.ForeColor = System.Drawing.Color.Navy;
      this.uiChangelistUser.Location = new System.Drawing.Point(209, 30);
      this.uiChangelistUser.Name = "uiChangelistUser";
      this.uiChangelistUser.Size = new System.Drawing.Size(55, 13);
      this.uiChangelistUser.TabIndex = 4;
      this.uiChangelistUser.Text = "Username";
      // 
      // uiChangelistNumber
      // 
      this.uiChangelistNumber.AutoSize = true;
      this.uiChangelistNumber.ForeColor = System.Drawing.Color.Navy;
      this.uiChangelistNumber.Location = new System.Drawing.Point(90, 30);
      this.uiChangelistNumber.Name = "uiChangelistNumber";
      this.uiChangelistNumber.Size = new System.Drawing.Size(37, 13);
      this.uiChangelistNumber.TabIndex = 3;
      this.uiChangelistNumber.Text = "12345";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(307, 30);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "Date:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(171, 30);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(32, 13);
      this.label4.TabIndex = 1;
      this.label4.Text = "User:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 30);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(69, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Changelist #:";
      // 
      // SelectChangelist
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(556, 512);
      this.ControlBox = false;
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "SelectChangelist";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Select Changelist";
      this.Load += new System.EventHandler(this.SelectChangelist_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker uiFromDate;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker uiToDate;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox uiHideRecentlyReviewedUsers;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label uiChangelistDate;
    private System.Windows.Forms.Label uiChangelistUser;
    private System.Windows.Forms.Label uiChangelistNumber;
    private System.Windows.Forms.ListBox uiChangelistFiles;
    private System.Windows.Forms.ListBox uiChangelists;
  }
}