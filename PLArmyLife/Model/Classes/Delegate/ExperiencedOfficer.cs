using PLArmyLife.Model.Enums;
using System;
using PLArmyLife.Model.Classes.Iterator;

namespace PLArmyLife.Model.Classes.Delegate
{
    class ExperiencedOfficer : Solder
    {
        /// <summary>
        /// Офицер
        /// Много знает
        /// Отдает команды
        /// </summary>
        public ExperiencedOfficer()
        {
            this.Greeting = String.Format("Я опытный офицер:");
            command = new HighRank();
            equipment = new HighLevelKnowledge();
            rank = ERank.Майор;
        }
    }
}
