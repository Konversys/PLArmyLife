using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Singleton
{
    class Event
    {
        public Event(int year, string title, string message)
        {
            Year = year;
            Title = title;
            Message = message;
        }

        public int Year { get; private set; }
        public string Title { get; private set; }
        public string Message { get; private set; }
    }
}
