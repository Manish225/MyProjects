using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Huddle.Business;
using System.Data.OleDb;

namespace Huddle
{
	public partial class frmViewEvents : Form
	{
		public frmViewEvents()
		{
			InitializeComponent();
		}

		private void frmViewEvents_Load(object sender, EventArgs e)
		{
			myData.MyCon.Open();
			OleDbCommand myCmd = new OleDbCommand("select EventName,RefEvent,EventDate from Events",myData.MyCon);
			OleDbDataReader myRead = myCmd.ExecuteReader();
			while (myRead.Read())
			{
				cboItem item = new cboItem();
				item.Text = myRead["EventName"].ToString()+"    "+myRead["EventDate"];
				item.Val = Convert.ToInt32(myRead["RefEvent"].ToString());
				lstEvents.Items.Add(item);
			}
			myRead.Close();
			myData.MyCon.Close();
		}

		private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
		{


			myData.MyCon.Open();
			OleDbCommand myCmd = new OleDbCommand("select MemberName as [Name],state as [State] from Members,EventMembers where Members.RefMember = EventMembers.RefMember and RefEvent=" + ((cboItem)lstEvents.SelectedItem).Val, myData.MyCon);
			OleDbDataReader myRead = myCmd.ExecuteReader();
			
			DataTable tb = new DataTable();
			tb.Load(myRead);
			gridPlayers.DataSource = tb;
			myData.MyCon.Close();

		}

		private void btnGoBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
