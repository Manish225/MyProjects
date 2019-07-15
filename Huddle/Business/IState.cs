using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huddle.Business
{
	interface IState
	{
		bool CanPlay();
	}
}
