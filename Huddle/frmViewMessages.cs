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
	public partial class frmViewMessages : Form
	{
		static DataSet myset;
		static DataTable tabMessages;
		static OleDbDataAdapter adpMessages;
		int Memid;
		public frmViewMessages()
		{
			InitializeComponent();
		}
		public frmViewMessages(int id)
		{
			Memid = id;
			InitializeComponent();
		}

		private void frmViewMessages_Load(object sender, EventArgs e)
		{
			myset = new DataSet();
			myData.MyCon.Open();
			OleDbCommand myCmd = new OleDbCommand("Select MemberName as [From],Subject,Desc from Messages,Members where Messages.Sender=Members.RefMember and Receiver=" +Memid, myData.MyCon);
			 adpMessages = new OleDbDataAdapter(myCmd);
			adpMessages.Fill(myset, "messages");
			tabMessages = myset.Tables["messages"];


			gridMessages.DataSource = tabMessages;
			gridMessages.Columns.Add("Actions", "");
			gridMessages.MultiSelect = false;
			myData.MyCon.Close();
		}

		private void btnGoBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
