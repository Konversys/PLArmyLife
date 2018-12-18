using PLArmyLife.Model.Interfaces;
using PLArmyLife.Model.Interfaces.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Bridge
{
    /// <summary>
    /// План действий на случай войны
    /// Конкретная реализация, которая унаследована от Implementor
    /// </summary>
    class PlanA : IPlan
    {
        public string Greeting { get; private set; }
        public PlanA()
        {
             this.Greeting = String.Format(" Используем план А");
        }

        public string Attack()
        {
            return String.Format("     Атакуем с левого фланга");
        }

        public string Retreat()
        {
            return String.Format("     Отступаем через деревню. Подрываем мост после себя");
        }

        public string TakePosition()
        {
            return String.Format("     Занять позицию у подножья горы");
        }
    }
}
