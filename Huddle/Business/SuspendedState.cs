using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huddle.Business
{
	class SuspendedState : IState
	{
		private static SuspendedState myInstance = null;
		private SuspendedState() { }

		public static SuspendedState GetInstance()
		{
			if (myInstance == null)
			{
				myInstance = new SuspendedState();
			}
			return myInstance;
		}
		public bool CanPlay()
		{
			return false;
		}
	}
}
