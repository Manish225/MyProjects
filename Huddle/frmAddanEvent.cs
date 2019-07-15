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
	public partial class frmAddanEvent : Form
	{
		public frmAddanEvent()
		{
			InitializeComponent();
		}

		private void frmAddanEvent_Load(object sender, EventArgs e)
		{
			myData.MyCon.Open();
			OleDbCommand myCmd = new OleDbCommand("Select MemberName,RefMember from Members where state='available'",myData.MyCon);
			OleDbDataReader myRead = myCmd.ExecuteReader();
			
			while (myRead.Read())
			{
				cboItem item = new cboItem();
				item.Val = Convert.ToInt32(myRead["RefMember"].ToString());
				item.Text = myRead["MemberName"].ToString();
				cboPlayers.Items.Add(item);
			}
			
			myRead.Close();
			myData.MyCon.Close();
			

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Event anEvent = new Event();
			anEvent.EventName = txtName.Text;
			anEvent.EventDesc = txtDescription.Text;
			anEvent.EventDate = DateTime.Parse(dateEvent.Text);
			myData.MyCon.Open();
			OleDbCommand myCmd = new OleDbCommand("Insert into [Events](EventDesc,EventDate,EventName) Values('"+anEvent.EventDesc+"','"+anEvent.EventDate.ToString()+"','"+anEvent.EventName+"')",myData.MyCon);
			myCmd.ExecuteNonQuery();
			MessageBox.Show("Event Added");
			OleDbCommand myCmd2 = new OleDbCommand("Select Max(RefEvent) as [eve] from Events", myData.MyCon);
			OleDbDataReader myRead2 = myCmd2.ExecuteReader();
			int evntid=0;
			if (myRead2.Read())
			{
				 evntid = Convert.ToInt32(myRead2["eve"].ToString());
			}
			foreach (cboItem item in lstPlayers.Items)
			{
				OleDbCommand myCmd1 = new OleDbCommand("Insert into [EventMembers](RefEvent,RefMember) Values(" + evntid.ToString() + "," +item.Val.ToString() +")", myData.MyCon);
				myCmd1.ExecuteNonQuery();
			}
			MessageBox.Show("Players Added");
			myData.MyCon.Close();
			
		}

		private void cboPlayers_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void btnAddPlayer_Click(object sender, EventArgs e)
		{
			
			cboItem item = new cboItem();
			item.Text = ((cboItem)cboPlayers.SelectedItem).Text;
			item.Val = ((cboItem)cboPlayers.SelectedItem).Val;
			lstPlayers.Items.Add(item);
			

			cboPlayers.Items.Remove(cboPlayers.SelectedItem);
		}
	}
}
