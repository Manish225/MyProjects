using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.OleDb;

namespace Huddle.Business
{
	

	class Message : IMessage
	{
		

		private int sender;
		private int receiver;
		private string subject;
		private string messageDesc;

		public int Sender { get => sender; set => sender = value; }
		public int Receiver { get => receiver; set => receiver = value; }
		public string Subject { get => subject; set => subject = value; }
		public string MessageDesc { get => messageDesc; set => messageDesc = value; }

		public void SendMesssage()
		{
			
			string sql = "Insert into [Messages]([Receiver],[Sender],[Subject],[Desc]) Values(" + this.receiver + "," + this.sender +  ",'" + this.subject + "','" + this.messageDesc + "')";
			OleDbCommand myCmd = new OleDbCommand(sql, myData.MyCon);
			myCmd.ExecuteNonQuery();
			

		}

		public override string ToString()
		{
			return receiver + "," + sender + ",'" + subject + "','" + messageDesc;
		}
	}
}
