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
	public partial class frmForgotPassword : Form
	{
		int Memid;
		string ans;
		public frmForgotPassword()
		{
			InitializeComponent();
		}
		public frmForgotPassword(int id)
		{
			Memid = id;
			InitializeComponent();
		}

		private void frmForgotPassword_Load(object sender, EventArgs e)
		{
			txtQuestion.Enabled = false;
			myData.MyCon.Open();
			OleDbCommand myCmd = new OleDbCommand("Select MemberQuestion,MemberAns from Members where RefMember="+Memid,myData.MyCon);
			OleDbDataReader myRead = myCmd.ExecuteReader();
			if (myRead.Read())
			{
				txtQuestion.Text = myRead["MemberQuestion"].ToString();
				ans = myRead["MemberAns"].ToString();
			}
			myData.MyCon.Close();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ans == txtAnswer.Text)
			{
				if (txtPassword.Text.Length > 4)
				{
					myData.MyCon.Open();
					OleDbCommand myCmd = new OleDbCommand("Update Members set MemberPassword='" + txtPassword.Text + "' where RefMember=" + Memid+";", myData.MyCon);
					myCmd.ExecuteNonQuery();
					MessageBox.Show("Successfully changed");
					myData.MyCon.Close();
					this.Close();
				}
				else {

					MessageBox.Show("At least 4 characters");
					txtPassword.Focus();
				}

			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
