using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huddle.Business
{
	class Member 
	{

		private string userName;
		private string memberName;
		private string password;
		private string question;
		private string type;
		private string answer;
		private List<Message> myMessages;

		public string MemberName { get => memberName; set => memberName = value; }
		public string Password { get => password; set => password = value; }
		public string Answer { get => answer; set => answer = value; }
		public string Type { get => type; set => type = value; }
		public string Question { get => question; set => question = value; }
		public string UserName { get => userName; set => userName = value; }
		internal List<Message> MyMessages { get => myMessages; set => myMessages = value; }

	}
}
