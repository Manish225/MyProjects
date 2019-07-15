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
using System.Data;
using Huddle.Business;

namespace Huddle
{
	public partial class frmHome : Form
	{
		 int Memid=0;
		public frmHome()
		{
			InitializeComponent();
		}
		public frmHome(string id)
		{
			Memid = Convert.ToInt32(id);

			InitializeComponent();
		}

		private void frmHome_Load(object sender, EventArgs e)
		{

			btnEvent.Visible = false;
			myData.MyCon.Open();
			OleDbCommand myCmd = new OleDbCommand("Select MemberType from Members where RefMember="+Memid,myData.MyCon);
			OleDbDataReader myRead = myCmd.ExecuteReader();
			if (myRead.Read())
			{
				if (myRead["MemberType"].ToString() == "Coach")
				{
					btnEvent.Visible = true;
				}
			}
			else {
				btnSendMessage.Visible = false;
				btnView.Visible = false;
				
			}

			myRead.Close();
			myData.MyCon.Close();


		}

		private void btnView_Click(object sender, EventArgs e)
		{

			frmViewMessages frm = new frmViewMessages(Memid);
			frm.ShowDialog();
		}

		private void btnEvent_Click(object sender, EventArgs e)
		{
			frmAddanEvent frm = new frmAddanEvent();
			frm.ShowDialog();


		}

		private void btnSendMessage_Click(object sender, EventArgs e)
		{
			frmSendMessage frm = new frmSendMessage(Memid);
			frm.ShowDialog();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnViewEvents_Click(object sender, EventArgs e)
		{
			frmViewEvents frm = new frmViewEvents();
			this.Visible = false;
			frm.ShowDialog();
			this.Visible = true;
		}
	}
}
