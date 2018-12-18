using PLArmyLife.Model.Interfaces.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Iterator
{
    class RollCall
    {
        /// <summary>
        /// Произвести перекличку взвода
        /// </summary>
        /// <param name="platoon">Взвод</param>
        public List<string> Begin(Platoon platoon)
        {
            List<string> vs = new List<string>();
            vs.Add(String.Format("Перекличка взвода: {0}", platoon.title));
            ISolderIterator iterator = platoon.CreateNumerator();
            while (iterator.HasNext())
            {
                Solder solder = iterator.Next();
                vs.Add(String.Format(" Я: {0}. Должность: {1}", solder.name, solder.post));
            }
            return vs;
        }
    }
}
