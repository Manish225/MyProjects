using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huddle.Business
{
	class Player : Member
	{
		private IState currentState;

		internal IState CurrentState { get => currentState; set => currentState = value; }
	}
}
