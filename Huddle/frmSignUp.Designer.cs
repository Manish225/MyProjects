namespace Huddle
{
	partial class frmSignUp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.cboQuestion = new System.Windows.Forms.ComboBox();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cboType = new System.Windows.Forms.ComboBox();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtQuestion = new System.Windows.Forms.TextBox();
			this.lblError = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.radQuestion = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(57, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(57, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Confirm Password :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(57, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Question :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(57, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Answer :";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(187, 45);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(121, 20);
			this.txtName.TabIndex = 5;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(187, 74);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(121, 20);
			this.txtPassword.TabIndex = 6;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(187, 104);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(121, 20);
			this.txtConfirmPassword.TabIndex = 7;
			// 
			// cboQuestion
			// 
			this.cboQuestion.FormattingEnabled = true;
			this.cboQuestion.Location = new System.Drawing.Point(187, 133);
			this.cboQuestion.Name = "cboQuestion";
			this.cboQuestion.Size = new System.Drawing.Size(245, 21);
			this.cboQuestion.TabIndex = 8;
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(187, 159);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(121, 20);
			this.txtAnswer.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(60, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Type :";
			// 
			// cboType
			// 
			this.cboType.FormattingEnabled = true;
			this.cboType.Location = new System.Drawing.Point(187, 193);
			this.cboType.Name = "cboType";
			this.cboType.Size = new System.Drawing.Size(121, 21);
			this.cboType.TabIndex = 11;
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnSignUp.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignUp.ForeColor = System.Drawing.SystemColors.Info;
			this.btnSignUp.Location = new System.Drawing.Point(221, 225);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(113, 43);
			this.btnSignUp.TabIndex = 12;
			this.btnSignUp.Text = "Sign Up";
			this.btnSignUp.UseVisualStyleBackColor = false;
			this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.Info;
			this.btnCancel.Location = new System.Drawing.Point(351, 225);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(113, 43);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtQuestion
			// 
			this.txtQuestion.Location = new System.Drawing.Point(525, 135);
			this.txtQuestion.Name = "txtQuestion";
			this.txtQuestion.Size = new System.Drawing.Size(195, 20);
			this.txtQuestion.TabIndex = 15;
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.Location = new System.Drawing.Point(63, 225);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 17);
			this.lblError.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(357, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Username :";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(525, 45);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(100, 20);
			this.txtUserName.TabIndex = 18;
			// 
			// radQuestion
			// 
			this.radQuestion.AutoSize = true;
			this.radQuestion.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radQuestion.Location = new System.Drawing.Point(525, 108);
			this.radQuestion.Name = "radQuestion";
			this.radQuestion.Size = new System.Drawing.Size(184, 21);
			this.radQuestion.TabIndex = 19;
			this.radQuestion.Text = "Create your own Question";
			this.radQuestion.UseVisualStyleBackColor = true;
			this.radQuestion.CheckedChanged += new System.EventHandler(this.radQuestion_CheckedChanged_1);
			// 
			// frmSignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.radQuestion);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.txtQuestion);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.cboType);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.cboQuestion);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmSignUp";
			this.Text = "Sign Up";
			this.Load += new System.EventHandler(this.frmSignUp_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.ComboBox cboQuestion;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboType;
		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtQuestion;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.CheckBox radQuestion;
	}
}