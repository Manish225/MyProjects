namespace Huddle
{
	partial class frmAddanEvent
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.dateEvent = new System.Windows.Forms.DateTimePicker();
			this.cboPlayers = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lstPlayers = new System.Windows.Forms.ListBox();
			this.btnAddPlayer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(61, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Date :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(61, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Description :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(61, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Add a Player :";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(176, 61);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(200, 20);
			this.txtName.TabIndex = 4;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(176, 97);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(200, 35);
			this.txtDescription.TabIndex = 7;
			this.txtDescription.Text = "";
			// 
			// dateEvent
			// 
			this.dateEvent.Location = new System.Drawing.Point(176, 139);
			this.dateEvent.Name = "dateEvent";
			this.dateEvent.Size = new System.Drawing.Size(200, 20);
			this.dateEvent.TabIndex = 8;
			// 
			// cboPlayers
			// 
			this.cboPlayers.FormattingEnabled = true;
			this.cboPlayers.Location = new System.Drawing.Point(176, 170);
			this.cboPlayers.Name = "cboPlayers";
			this.cboPlayers.Size = new System.Drawing.Size(200, 21);
			this.cboPlayers.TabIndex = 9;
			this.cboPlayers.SelectedIndexChanged += new System.EventHandler(this.cboPlayers_SelectedIndexChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.Info;
			this.btnAdd.Location = new System.Drawing.Point(64, 230);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(108, 35);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lstPlayers
			// 
			this.lstPlayers.FormattingEnabled = true;
			this.lstPlayers.Location = new System.Drawing.Point(515, 170);
			this.lstPlayers.Name = "lstPlayers";
			this.lstPlayers.Size = new System.Drawing.Size(120, 95);
			this.lstPlayers.TabIndex = 11;
			// 
			// btnAddPlayer
			// 
			this.btnAddPlayer.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnAddPlayer.ForeColor = System.Drawing.SystemColors.Info;
			this.btnAddPlayer.Location = new System.Drawing.Point(392, 170);
			this.btnAddPlayer.Name = "btnAddPlayer";
			this.btnAddPlayer.Size = new System.Drawing.Size(91, 27);
			this.btnAddPlayer.TabIndex = 12;
			this.btnAddPlayer.Text = ">>";
			this.btnAddPlayer.UseVisualStyleBackColor = false;
			this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
			// 
			// frmAddanEvent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAddPlayer);
			this.Controls.Add(this.lstPlayers);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cboPlayers);
			this.Controls.Add(this.dateEvent);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmAddanEvent";
			this.Text = "Add an Event";
			this.Load += new System.EventHandler(this.frmAddanEvent_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.RichTextBox txtDescription;
		private System.Windows.Forms.DateTimePicker dateEvent;
		private System.Windows.Forms.ComboBox cboPlayers;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ListBox lstPlayers;
		private System.Windows.Forms.Button btnAddPlayer;
	}
}