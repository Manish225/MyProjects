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
	public partial class frmSignUp : Form
	{
		
		public frmSignUp()
		{
			InitializeComponent();
		}
		static bool error = false;

		private void frmSignUp_Load(object sender, EventArgs e)
		{
			


			cboQuestion.Items.Add("What was the name of your first pet?");
			cboQuestion.Items.Add("What was the color of your first Car?");
			cboQuestion.Items.Add("what year did you finish High School?");
			cboQuestion.Items.Add("What is your favorite ice-cream flavour?");
			cboType.Items.Add("Coach");
			cboType.Items.Add("Player");
			txtQuestion.Enabled = false;

		}

		private void radQuestion_CheckedChanged(object sender, EventArgs e)
		{
			
			
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			Member aMember;
			if (cboType.Text == "Player")
			{
				aMember = new Player();
				((Player)aMember).CurrentState = ActiveState.GetInstance();
			}
			else {
				aMember = new Coach();

			}
			lblError.Text = "";
			aMember.MemberName = txtName.Text == "" ? lblError.Text += Validate(txtName) : txtName.Text ;

			
			if (txtPassword.Text == txtConfirmPassword.Text)
			{
				aMember.Password =txtPassword.Text=="" ?lblError.Text += Validate(txtPassword): txtPassword.Text;
			}
			else MessageBox.Show("Password do not match","Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			aMember.Question = radQuestion.Checked ? txtQuestion.Text == "" ? lblError.Text += Validate(txtQuestion) : txtQuestion.Text : cboQuestion.SelectedIndex>-1? cboQuestion.SelectedItem.ToString(): lblError.Text+=Validate(cboQuestion);

			aMember.Answer = txtAnswer.Text == "" ? lblError.Text += Validate(txtAnswer) : txtAnswer.Text;

			aMember.Type = cboType.SelectedIndex > -1 ? cboType.Text : lblError.Text += Validate(cboType);

			aMember.UserName = txtUserName.Text == "" ? lblError.Text += Validate(txtUserName) : txtUserName.Text;


			if (!error)
			{
				myData.MyCon.Open();
				string sql = "Insert into Members(MemberName,MemberPassword,MemberQuestion,MemberAns,MemberType,username) Values('" + aMember.MemberName + "','" + aMember.Password + "','" + aMember.Question + "','" + aMember.Answer + "','" + aMember.Type + "','"+aMember.UserName+"')";
				OleDbCommand myCmd = new OleDbCommand(sql,myData.MyCon);
				myCmd.ExecuteNonQuery();
				myData.MyCon.Close();
				this.Close();
			
			}
			error = false;

			}


		private string Validate(Object obj)
		{
			error = true;
			if (obj is TextBox)
			return "Please fill in " + ((TextBox)obj).Name.Substring(3) +"\n";
			else if (obj is ComboBox)
			{
				return "Please Select a " + ((ComboBox)obj).Name.Substring(3) + "\n";
			}
			return "";
		}

		private void radQuestion_CheckedChanged_1(object sender, EventArgs e)
		{
			cboQuestion.SelectedIndex = -1;
			if (radQuestion.Checked == true)
			{
				cboQuestion.Enabled = false;
				txtQuestion.Enabled = true;
			}
			else
			{
				cboQuestion.Enabled = true;
				txtQuestion.Enabled = false;

			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

		
}
