namespace Huddle
{
	partial class frmSendMessage
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
			this.cboContacts = new System.Windows.Forms.ComboBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.RichTextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Subject :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "To :";
			// 
			// cboContacts
			// 
			this.cboContacts.FormattingEnabled = true;
			this.cboContacts.Location = new System.Drawing.Point(114, 31);
			this.cboContacts.Name = "cboContacts";
			this.cboContacts.Size = new System.Drawing.Size(121, 21);
			this.cboContacts.TabIndex = 2;
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(114, 63);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(121, 20);
			this.txtSubject.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Message :";
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(114, 128);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(145, 96);
			this.txtMessage.TabIndex = 6;
			this.txtMessage.Text = "";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(114, 231);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 7;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// frmSendMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.cboContacts);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmSendMessage";
			this.Text = "Send a Message";
			this.Load += new System.EventHandler(this.frmSendMessage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboContacts;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox txtMessage;
		private System.Windows.Forms.Button btnSend;
	}
}