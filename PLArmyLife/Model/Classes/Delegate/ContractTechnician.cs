﻿using PLArmyLife.Model.Enums;
using System;

namespace PLArmyLife.Model.Classes.Delegate
{
    class ContractTechnician : Serviceman
    {
        /// <summary>
        /// Технарь
        /// Много знает
        /// Выполняет команды
        /// </summary>
        public ContractTechnician()
        {
            this.Greeting = String.Format("Я контрактник - выпускник технического училища:");
            command = new LowRank();
            equipment = new HighLevelKnowledge();
            rank = ERank.Sergeant;
        }
    }
}
