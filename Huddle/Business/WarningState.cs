using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huddle.Business
{
	class WarningState : IState
	{
		private static WarningState myInstance = null;
		private WarningState() { }

		public static WarningState GetInstance()
		{
			if (myInstance == null)
			{
				myInstance = new WarningState();
			}
			return myInstance;
		}
		public bool CanPlay()
		{
			return true;
		}
	}
}
