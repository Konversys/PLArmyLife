using PLArmyLife.Model.Interfaces.Bridge;
using System;

namespace PLArmyLife.Model.Classes.Bridge
{
    /// <summary>
    /// План действий на случай войны
    /// Конкретная реализация, которая унаследована от Implementor
    /// </summary>
    class PlanB : IPlan
    {
        public string Greeting { get; private set; }

        public PlanB()
        {
            this.Greeting = String.Format(" Используем план Б");
        }

        public string Attack()
        {
            return String.Format("     Атакуем, обойдя с тыла");
        }

        public string Retreat()
        {
            return String.Format("     Отступаем через лесополосу");
        }

        public string TakePosition()
        {
            return String.Format("     Занимаем позицию за городским элеватором");
        }
    }
}