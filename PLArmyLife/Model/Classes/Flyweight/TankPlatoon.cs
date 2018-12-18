using PLArmyLife.Model.Classes.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Flyweight
{
    /// <summary>
    /// Танковый взвод
    /// </summary>
    class TankPlatoon : Platoon
    {
        public TankPlatoon()
        {
        }

        public override string SetTitleAndConnect(string title)
        {
            return String.Format(" Танковый взвод {0} присоединился к батальону", title);
        }
    }
}
