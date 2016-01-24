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
      this.label1 = new System.Windows.Forms.Label();
      this.uiFromDate = new System.Windows.Forms.DateTimePicker();
      this.uiToDate = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.uiChangelists = new System.Windows.Forms.ListView();
      this.uiHideRecentlyReviewedUsers = new System.Windows.Forms.CheckBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
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
      this.groupBox1.Size = new System.Drawing.Size(284, 92);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Filters:";
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
      // uiFromDate
      // 
      this.uiFromDate.CustomFormat = "yyyy/MM/dd";
      this.uiFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.uiFromDate.Location = new System.Drawing.Point(54, 26);
      this.uiFromDate.Name = "uiFromDate";
      this.uiFromDate.Size = new System.Drawing.Size(92, 20);
      this.uiFromDate.TabIndex = 1;
      // 
      // uiToDate
      // 
      this.uiToDate.CustomFormat = "yyyy/MM/dd";
      this.uiToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.uiToDate.Location = new System.Drawing.Point(174, 26);
      this.uiToDate.Name = "uiToDate";
      this.uiToDate.Size = new System.Drawing.Size(92, 20);
      this.uiToDate.TabIndex = 2;
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
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.uiChangelists);
      this.groupBox2.Location = new System.Drawing.Point(12, 110);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
      this.groupBox2.Size = new System.Drawing.Size(284, 253);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Changelists:";
      // 
      // uiChangelists
      // 
      this.uiChangelists.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiChangelists.Location = new System.Drawing.Point(8, 21);
      this.uiChangelists.Name = "uiChangelists";
      this.uiChangelists.Size = new System.Drawing.Size(268, 224);
      this.uiChangelists.TabIndex = 0;
      this.uiChangelists.UseCompatibleStateImageBehavior = false;
      this.uiChangelists.View = System.Windows.Forms.View.List;
      // 
      // uiHideRecentlyReviewedUsers
      // 
      this.uiHideRecentlyReviewedUsers.AutoSize = true;
      this.uiHideRecentlyReviewedUsers.Location = new System.Drawing.Point(54, 61);
      this.uiHideRecentlyReviewedUsers.Name = "uiHideRecentlyReviewedUsers";
      this.uiHideRecentlyReviewedUsers.Size = new System.Drawing.Size(165, 17);
      this.uiHideRecentlyReviewedUsers.TabIndex = 4;
      this.uiHideRecentlyReviewedUsers.Text = "Hide recently reviewed users.";
      this.uiHideRecentlyReviewedUsers.UseVisualStyleBackColor = true;
      // 
      // SelectChangelist
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(310, 420);
      this.ControlBox = false;
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "SelectChangelist";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Select Changelist";
      this.Load += new System.EventHandler(this.SelectChangelist_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker uiFromDate;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker uiToDate;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListView uiChangelists;
    private System.Windows.Forms.CheckBox uiHideRecentlyReviewedUsers;
  }
}