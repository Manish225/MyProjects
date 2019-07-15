using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Huddle.Business;
namespace Huddle
{
	public partial class frmSendMessage : Form
	{
		
		  int id ;
		public frmSendMessage()
		{
			InitializeComponent();
		}
		public frmSendMessage(int id)
		{
			this.id = id;
			InitializeComponent();
		}

		private void frmSendMessage_Load(object sender, EventArgs e)
		{
			myData.MyCon.Open();

			string sql = "Select username,RefMember from Members";
			OleDbCommand myCmd = new OleDbCommand(sql, myData.MyCon);
			OleDbDataReader myRead = myCmd.ExecuteReader();

			while (myRead.Read())
			{
				if(myRead["RefMember"].ToString()!=id.ToString())
				cboContacts.Items.Add(myRead["username"].ToString());
			}
			myData.MyCon.Close();

		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			myData.MyCon.Open();
			Business.Message aMessage = new Business.Message();
			aMessage.Sender = id;
			string sql = "Select RefMember from Members where username='"+cboContacts.SelectedItem.ToString() + "'";
			OleDbCommand myCmd = new OleDbCommand(sql, myData.MyCon);
			OleDbDataReader myRead = myCmd.ExecuteReader();
			if (myRead.Read())
			{
				aMessage.Receiver = Convert.ToInt32(myRead["RefMember"].ToString());
			}
			aMessage.Subject = txtSubject.Text;
			aMessage.MessageDesc = txtMessage.Text;
			MessageBox.Show(aMessage.ToString());
			aMessage.SendMesssage();
			MessageBox.Show("Message Sent");
			myData.MyCon.Close();
			this.Close();
		}
	}
}
