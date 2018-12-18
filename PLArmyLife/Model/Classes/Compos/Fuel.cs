using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces.Compos;
using System;
using System.Collections.Generic;

namespace PLArmyLife.Model.Classes.Compos
{
    /// <summary>
    /// Топливо
    /// </summary>
    class Fuel : IItem
    {
        public List<string> Take(ESubdivision subdivision)
        {
            List<string> vs = new List<string>();
            vs.Add(String.Format("Вы взяли топливо"));
            return vs;
        }
    }
}
