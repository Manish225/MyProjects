using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huddle.Business
{
	class Coach : Member
	{
		private List<Event> myEvents;
		private List<Player> players;

		public void CreateEvent(Event anEvent)
		{
			foreach (Event oneEvent in this.myEvents)
			{
				if (oneEvent.EventDate == anEvent.EventDate)
				{
					Console.WriteLine("there is a conflict. Want to continue?");
					if ("y" == Console.ReadLine())
					{
						myEvents.Add(anEvent);
						break;
					}
				}
			}
		}
	}
}
