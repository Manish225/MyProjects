using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huddle.Business
{
	class ActiveState : IState
	{
		private static ActiveState myInstance = null;
		private ActiveState() { }

		public static ActiveState GetInstance()
		{
			if (myInstance == null)
			{
				myInstance = new ActiveState();
			}
			return myInstance;
		}
		public bool CanPlay()
		{
			return true;
		}
	}
}
