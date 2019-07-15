namespace Huddle
{
	partial class frmHome
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
			this.btnSendMessage = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.btnEvent = new System.Windows.Forms.Button();
			this.btnViewEvents = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSendMessage
			// 
			this.btnSendMessage.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnSendMessage.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSendMessage.ForeColor = System.Drawing.SystemColors.Info;
			this.btnSendMessage.Location = new System.Drawing.Point(40, 57);
			this.btnSendMessage.Name = "btnSendMessage";
			this.btnSendMessage.Size = new System.Drawing.Size(132, 34);
			this.btnSendMessage.TabIndex = 0;
			this.btnSendMessage.Text = "Send a Message";
			this.btnSendMessage.UseVisualStyleBackColor = false;
			this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
			// 
			// btnView
			// 
			this.btnView.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnView.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnView.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnView.Location = new System.Drawing.Point(224, 57);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(132, 34);
			this.btnView.TabIndex = 1;
			this.btnView.Text = "View Messages";
			this.btnView.UseVisualStyleBackColor = false;
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// btnEvent
			// 
			this.btnEvent.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnEvent.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEvent.ForeColor = System.Drawing.SystemColors.Control;
			this.btnEvent.Location = new System.Drawing.Point(40, 111);
			this.btnEvent.Name = "btnEvent";
			this.btnEvent.Size = new System.Drawing.Size(132, 40);
			this.btnEvent.TabIndex = 2;
			this.btnEvent.Text = "Add an Event";
			this.btnEvent.UseVisualStyleBackColor = false;
			this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
			// 
			// btnViewEvents
			// 
			this.btnViewEvents.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnViewEvents.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewEvents.ForeColor = System.Drawing.SystemColors.Info;
			this.btnViewEvents.Location = new System.Drawing.Point(224, 111);
			this.btnViewEvents.Name = "btnViewEvents";
			this.btnViewEvents.Size = new System.Drawing.Size(132, 40);
			this.btnViewEvents.TabIndex = 3;
			this.btnViewEvents.Text = "View Events";
			this.btnViewEvents.UseVisualStyleBackColor = false;
			this.btnViewEvents.Click += new System.EventHandler(this.btnViewEvents_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Menu;
			this.btnLogout.Location = new System.Drawing.Point(40, 169);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(132, 34);
			this.btnLogout.TabIndex = 4;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnViewEvents);
			this.Controls.Add(this.btnEvent);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.btnSendMessage);
			this.Name = "frmHome";
			this.Text = "Home";
			this.Load += new System.EventHandler(this.frmHome_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSendMessage;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Button btnEvent;
		private System.Windows.Forms.Button btnViewEvents;
		private System.Windows.Forms.Button btnLogout;
	}
}