using PLArmyLife.Model.Enums;
using System;
using PLArmyLife.Model.Classes.Iterator;

namespace PLArmyLife.Model.Classes.Delegate
{
    class Conscript : Solder
    {
        /// <summary>
        /// Срочник новобранец
        /// Мало знает
        /// Выполняет команды
        /// </summary>
        public Conscript()
        {
            this.Greeting = String.Format("Я срочник-новобранец:");
            equipment = new LowLevelKnowledge();
            command = new LowRank();
            rank = ERank.Сержант;
        }
    }
}
