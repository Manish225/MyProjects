using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huddle.Business
{
	class cboItem
	{
		int val;
		string text;

		public int Val { get => val; set => val = value; }
		public string Text { get => text; set => text = value; }

		public override string ToString()
		{
			return text;
		}
	}
}
