using PLArmyLife.Model.Classes.Delegate;
using PLArmyLife.Model.Interfaces.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Adapter
{
    /// <summary>
    /// Рядовой срочник из США.
    /// Адаптируемый класс
    /// </summary>
    class ConscriptUSA : IServicemanUSA
    {
        public string Attack()
        {
            return String.Format("I'm Attack");
        }

        public string Retreat()
        {
            return String.Format("      I'm Retreat");
        }

        public string SetOrder()
        {
            return String.Format("      I'm can't Set Order");
        }

        public string GetOrder()
        {
            return String.Format("      I'm Get Order");
        }

        public string Repair()
        {
            return String.Format("      I'm don't know how to Repair");
        }

        public string Break()
        {
            return String.Format("      I'll will crash everything around me");
        }
    }
}
