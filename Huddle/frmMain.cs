using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huddle
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			frmSignUp frm = new frmSignUp();
			this.Visible = false;
			frm.ShowDialog();
			this.Visible = true;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			frmLogin frm = new frmLogin();
			this.Visible = false;
			frm.ShowDialog();
			this.Visible = true;
		}

		private void btnGuest_Click(object sender, EventArgs e)
		{
			frmHome frm = new frmHome();
			this.Visible = false;
			frm.ShowDialog();
			this.Visible = true;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
