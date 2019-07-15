using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huddle.Business
{
	class Event
	{
		private int eventId;
		private string eventName;
		private string eventDesc;
		private DateTime eventDate;
		private int maxSize;
		private List<Player> participents;
		public DateTime EventDate { get => eventDate; set => eventDate = value; }
		public int MaxSize { get => maxSize; set => maxSize = value; }
		public string EventDesc { get => eventDesc; set => eventDesc = value; }
		public string EventName { get => eventName; set => eventName = value; }

		public bool AddParticipant(Player aPlayer)
		{
			//check status of player
			if ((participents.Count < this.MaxSize) && (aPlayer.CurrentState.CanPlay()))
			{
				participents.Add(aPlayer);
				return true;
			}
			return false;
		}

	}
}
