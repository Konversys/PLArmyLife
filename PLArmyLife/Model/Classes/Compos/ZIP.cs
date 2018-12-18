using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces.Compos;
using System;
using System.Collections.Generic;

namespace PLArmyLife.Model.Classes.Compos
{
    /// <summary>
    /// Комплект ЗИП
    /// </summary>
    class ZIP : IItem
    {
        public List<string> Take(ESubdivision subdivision)
        {
            List<string> vs = new List<string>();
            vs.Add(String.Format("Вы взяли комплект ЗИП"));
            return vs;
        }
    }
}
