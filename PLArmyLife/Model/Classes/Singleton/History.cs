using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Singleton
{
    class History
    {
        private static History history;
        private static List<Event> events;

        public History GetHistory()
        {
            if (history == null)
            {
                history = new History();
            }

            return history;
        }

        public void AddEvent(Event @event)
        {
            events.Add(@event);
        }
        public List<Event> GetEventByYear(int year)
        {
            return events.Where(x => x.Year == year).ToList();
        }
        public Event GetEventByID(int id)
        {
            return events[id];
        }
        public List<Event> GetEventByTitle(string title)
        {
            return events.Where(x => x.Title == title).ToList();
        }
    }
}
