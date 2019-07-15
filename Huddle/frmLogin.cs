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
	public partial class frmLogin : Form
	{
	
		public frmLogin()
		{
		
			InitializeComponent();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			myData.MyCon.Open();
			string sql = "Select RefMember,username,MemberPassword from Members where username ='" + txtUserName.Text + "'";
			OleDbCommand myCmd = new OleDbCommand(sql, myData.MyCon);
			OleDbDataReader myRead = myCmd.ExecuteReader();

			if (myRead.Read() && txtUserName.Text.ToString().ToUpper() == myRead["username"].ToString().ToUpper() && txtPassword.Text == myRead["MemberPassword"].ToString())
			{

				this.Visible = false;
				frmHome frm = new frmHome(myRead["RefMember"].ToString());
				myData.MyCon.Close();
				frm.ShowDialog();
				this.Visible = true;
				lblcheck.Text = "";
				txtUserName.Text = "";
				txtPassword.Text = "";


			}
			else {
				lblcheck.Text = "Wrong UserName or Password";
			}
			myRead.Close();	
			myData.MyCon.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			frmSignUp frm = new frmSignUp();
			this.Visible = false;
			frm.ShowDialog();
			this.Visible = true;
		}

		private void btnForgotPassword_Click(object sender, EventArgs e)
		{
			myData.MyCon.Open();
			string sql = "Select RefMember from Members where username ='" + txtUserName.Text + "'";
			OleDbCommand myCmd = new OleDbCommand(sql, myData.MyCon);
			OleDbDataReader myRead = myCmd.ExecuteReader();

			int Memid=0;
			if (myRead.Read())
			{
				Memid = Convert.ToInt32(myRead["RefMember"].ToString());
			}

			if (Memid > 0)
			{
				myData.MyCon.Close();
				frmForgotPassword frm = new frmForgotPassword(Memid);
				frm.ShowDialog();
			}
			else {
				MessageBox.Show("There is some problem");
				myData.MyCon.Close();
			}

		}
	}
}
