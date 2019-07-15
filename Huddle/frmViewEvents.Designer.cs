namespace Huddle
{
	partial class frmViewEvents
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
			this.gridPlayers = new System.Windows.Forms.DataGridView();
			this.lstEvents = new System.Windows.Forms.ListBox();
			this.btnGoBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridPlayers)).BeginInit();
			this.SuspendLayout();
			// 
			// gridPlayers
			// 
			this.gridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPlayers.Location = new System.Drawing.Point(63, 127);
			this.gridPlayers.Name = "gridPlayers";
			this.gridPlayers.Size = new System.Drawing.Size(472, 150);
			this.gridPlayers.TabIndex = 0;
			// 
			// lstEvents
			// 
			this.lstEvents.FormattingEnabled = true;
			this.lstEvents.Location = new System.Drawing.Point(63, 33);
			this.lstEvents.Name = "lstEvents";
			this.lstEvents.Size = new System.Drawing.Size(283, 69);
			this.lstEvents.TabIndex = 1;
			this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
			// 
			// btnGoBack
			// 
			this.btnGoBack.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnGoBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGoBack.ForeColor = System.Drawing.SystemColors.Info;
			this.btnGoBack.Location = new System.Drawing.Point(378, 49);
			this.btnGoBack.Name = "btnGoBack";
			this.btnGoBack.Size = new System.Drawing.Size(125, 33);
			this.btnGoBack.TabIndex = 2;
			this.btnGoBack.Text = "Go Back";
			this.btnGoBack.UseVisualStyleBackColor = false;
			this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
			// 
			// frmViewEvents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnGoBack);
			this.Controls.Add(this.lstEvents);
			this.Controls.Add(this.gridPlayers);
			this.Name = "frmViewEvents";
			this.Text = "View Events";
			this.Load += new System.EventHandler(this.frmViewEvents_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridPlayers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridPlayers;
		private System.Windows.Forms.ListBox lstEvents;
		private System.Windows.Forms.Button btnGoBack;
	}
}