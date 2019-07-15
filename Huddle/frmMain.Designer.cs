namespace Huddle
{
	partial class frmMain
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
			this.btnSignUp = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnGuest = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnSignUp.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignUp.ForeColor = System.Drawing.SystemColors.Info;
			this.btnSignUp.Location = new System.Drawing.Point(110, 140);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(109, 38);
			this.btnSignUp.TabIndex = 0;
			this.btnSignUp.Text = "Sign Up";
			this.btnSignUp.UseVisualStyleBackColor = false;
			this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnLogin.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.SystemColors.Info;
			this.btnLogin.Location = new System.Drawing.Point(256, 140);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(112, 38);
			this.btnLogin.TabIndex = 1;
			this.btnLogin.Text = "Log In";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnGuest
			// 
			this.btnGuest.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnGuest.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuest.ForeColor = System.Drawing.SystemColors.Info;
			this.btnGuest.Location = new System.Drawing.Point(421, 140);
			this.btnGuest.Name = "btnGuest";
			this.btnGuest.Size = new System.Drawing.Size(124, 38);
			this.btnGuest.TabIndex = 2;
			this.btnGuest.Text = "Log In as a Guest";
			this.btnGuest.UseVisualStyleBackColor = false;
			this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.Info;
			this.btnExit.Location = new System.Drawing.Point(256, 195);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(112, 37);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGuest);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnSignUp);
			this.Name = "frmMain";
			this.Text = "Huddle";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnGuest;
		private System.Windows.Forms.Button btnExit;
	}
}