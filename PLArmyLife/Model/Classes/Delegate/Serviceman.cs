using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces;
using PLArmyLife.Model.Interfaces.Adapter;
using PLArmyLife.Model.Interfaces.Decorator;
using PLArmyLife.Model.Interfaces.Delegate;
using System;

namespace PLArmyLife.Model.Classes.Delegate
{
    /// <summary>
    /// Военнослужащий
    /// </summary>
    abstract class Serviceman : IServiceMan, IEmergency
    {
        public ERank rank { get; protected set; }

        public string Greeting { get; protected set; } 

        protected ICommand command { get; set; }
        protected IEquipment equipment { get; set; }
        public string[] CanICommand()
        {
            return new string[] { command.ExecuteOrder(), command.GiveOrder() };
        }
        
        public string[] CanIEquipment()
        {
            return new string[] { equipment.Repair(), equipment.Break() };
        }

        public string FollowInstructionInCaseOfFire()
        {
            return String.Format(" Я покину помещение.");
        }
    }
}
