using PLArmyLife.Model.Enums;
using System;

namespace PLArmyLife.Model.Classes.Delegate
{
    class ExperiencedOfficer : Serviceman
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
            rank = ERank.Major;
        }
    }
}
