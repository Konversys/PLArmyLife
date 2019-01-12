using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Singleton
{
    /// <summary>
    /// История
    /// </summary>
    class History
    {
        private static History history;
        /// <summary>
        /// События
        /// </summary>
        private static List<Event> events;

        /// <summary>
        /// Получить экземпляр
        /// </summary>
        /// <returns></returns>
        public static History GetHistory()
        {
            if (history == null)
            {
                history = new History();
                events = new List<Event>();
            }

            return history;
        }
        /// <summary>
        /// Добавить событие
        /// </summary>
        /// <param name="event"></param>
        public void AddEvent(Event @event)
        {
            events.Add(@event);
        }
        /// <summary>
        /// Получить список событий
        /// </summary>
        /// <returns></returns>
        public List<Event> GetEvents()
        {
            return events;
        }
        /// <summary>
        /// Получить список событий по году
        /// </summary>
        /// <returns></returns>
        public List<Event> GetEventByYear(int year)
        {
            return events.Where(x => x.Year == year).ToList();
        }
        /// <summary>
        /// Получить список индексу
        /// </summary>
        /// <returns></returns>
        public Event GetEventByID(int index)
        {
            return events[index];
        }
        /// <summary>
        /// Получить список событий по названию
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Event> GetEventByTitle(string title)
        {
            return events.Where(x => x.Title == title).ToList();
        }
    }
}
