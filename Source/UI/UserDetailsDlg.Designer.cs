namespace Critr.UI
{
  partial class UserDetailsDlg
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
      this.label1 = new System.Windows.Forms.Label();
      this.uiP4Username = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.uiFirstName = new System.Windows.Forms.TextBox();
      this.uiLastName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.uiPassword = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.uiOK = new System.Windows.Forms.Button();
      this.uiCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "P4 username:";
      // 
      // uiP4Username
      // 
      this.uiP4Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.uiP4Username.FormattingEnabled = true;
      this.uiP4Username.Location = new System.Drawing.Point(110, 22);
      this.uiP4Username.Name = "uiP4Username";
      this.uiP4Username.Size = new System.Drawing.Size(151, 21);
      this.uiP4Username.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "First name:";
      // 
      // uiFirstName
      // 
      this.uiFirstName.Location = new System.Drawing.Point(110, 57);
      this.uiFirstName.MaxLength = 50;
      this.uiFirstName.Name = "uiFirstName";
      this.uiFirstName.Size = new System.Drawing.Size(151, 20);
      this.uiFirstName.TabIndex = 3;
      // 
      // uiLastName
      // 
      this.uiLastName.Location = new System.Drawing.Point(110, 83);
      this.uiLastName.MaxLength = 50;
      this.uiLastName.Name = "uiLastName";
      this.uiLastName.Size = new System.Drawing.Size(151, 20);
      this.uiLastName.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 86);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Last name:";
      // 
      // uiPassword
      // 
      this.uiPassword.Location = new System.Drawing.Point(110, 109);
      this.uiPassword.MaxLength = 50;
      this.uiPassword.Name = "uiPassword";
      this.uiPassword.Size = new System.Drawing.Size(151, 20);
      this.uiPassword.TabIndex = 7;
      this.uiPassword.UseSystemPasswordChar = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 112);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Password:";
      // 
      // uiOK
      // 
      this.uiOK.Location = new System.Drawing.Point(110, 150);
      this.uiOK.Name = "uiOK";
      this.uiOK.Size = new System.Drawing.Size(70, 29);
      this.uiOK.TabIndex = 8;
      this.uiOK.Text = "OK";
      this.uiOK.UseVisualStyleBackColor = true;
      // 
      // uiCancel
      // 
      this.uiCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.uiCancel.Location = new System.Drawing.Point(191, 150);
      this.uiCancel.Name = "uiCancel";
      this.uiCancel.Size = new System.Drawing.Size(70, 29);
      this.uiCancel.TabIndex = 9;
      this.uiCancel.Text = "Cancel";
      this.uiCancel.UseVisualStyleBackColor = true;
      // 
      // UserDetailsDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.uiCancel;
      this.ClientSize = new System.Drawing.Size(284, 201);
      this.ControlBox = false;
      this.Controls.Add(this.uiCancel);
      this.Controls.Add(this.uiOK);
      this.Controls.Add(this.uiPassword);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.uiLastName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.uiFirstName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.uiP4Username);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "UserDetailsDlg";
      this.Text = "User Details";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox uiP4Username;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox uiFirstName;
    private System.Windows.Forms.TextBox uiLastName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox uiPassword;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button uiOK;
    private System.Windows.Forms.Button uiCancel;
  }
}