using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Huddle.Business
{
	static class myData
	{

		static private OleDbConnection myCon =new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../Data/HuddleDatabase.mdb");

		public static OleDbConnection MyCon { get => myCon; set => myCon = value; }
	}
}
