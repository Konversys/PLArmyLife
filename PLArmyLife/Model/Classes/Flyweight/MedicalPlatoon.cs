using PLArmyLife.Model.Classes.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Flyweight
{
    /// <summary>
    /// Мед. взвод
    /// </summary>
    class MedicalPlatoon : Platoon
    {
        public MedicalPlatoon()
        {
        }

        public override string SetTitleAndConnect(string title)
        {
            return String.Format(" Мед. взвод {0} присоединился к батальону", title);
        }
    }
}