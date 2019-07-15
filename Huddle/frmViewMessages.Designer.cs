namespace Huddle
{
	partial class frmViewMessages
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
			this.gridMessages = new System.Windows.Forms.DataGridView();
			this.btnGoBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridMessages)).BeginInit();
			this.SuspendLayout();
			// 
			// gridMessages
			// 
			this.gridMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMessages.Location = new System.Drawing.Point(63, 97);
			this.gridMessages.Name = "gridMessages";
			this.gridMessages.Size = new System.Drawing.Size(603, 150);
			this.gridMessages.TabIndex = 0;
			// 
			// btnGoBack
			// 
			this.btnGoBack.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnGoBack.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGoBack.ForeColor = System.Drawing.SystemColors.Info;
			this.btnGoBack.Location = new System.Drawing.Point(63, 38);
			this.btnGoBack.Name = "btnGoBack";
			this.btnGoBack.Padding = new System.Windows.Forms.Padding(5);
			this.btnGoBack.Size = new System.Drawing.Size(124, 41);
			this.btnGoBack.TabIndex = 1;
			this.btnGoBack.Text = "Go Back";
			this.btnGoBack.UseVisualStyleBackColor = false;
			this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
			// 
			// frmViewMessages
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnGoBack);
			this.Controls.Add(this.gridMessages);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmViewMessages";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "View Messages";
			this.Load += new System.EventHandler(this.frmViewMessages_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridMessages)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridMessages;
		private System.Windows.Forms.Button btnGoBack;
	}
}