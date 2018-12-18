using PLArmyLife.Model.Classes.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Flyweight
{
    /// <summary>
    /// Арта
    /// </summary>
    class AirdefensePlatoon : Platoon
    {
        public AirdefensePlatoon()
        {
        }

        public override string SetTitleAndConnect(string title)
        {
            return String.Format(" Арт. взвод {0} присоединился к батальону", title);
        }
    }
}