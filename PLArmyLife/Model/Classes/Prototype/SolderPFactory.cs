using PLArmyLife.Model.Classes.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Prototype
{
    /// <summary>
    /// Фабрика солдат
    /// Инициализация с экземпляром и получение копий экземпляра
    /// </summary>
    class SolderPFactory
    {
        Solder solder;

        public SolderPFactory(Solder solder)
        {
            this.solder = solder;
        }

        public void SetPrototype(Solder solder)
        {
            this.solder = solder;
        }

        public Solder MakeCopy()
        {
            return solder.Copy();
        }
    }
}
