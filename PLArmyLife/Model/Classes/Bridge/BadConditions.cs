using PLArmyLife.Model.Interfaces.AbstractFactory;
using PLArmyLife.Model.Interfaces.Bridge;
using System;

namespace PLArmyLife.Model.Classes.Bridge
{
    /// <summary>
    /// Плохой исход войны
    /// Уточненная абстракция
    /// </summary>
    class BadConditions : War, ICondition
    {
        public BadConditions(IPlan plan) : base(plan)
        {
        }

        public override string Report()
        {
            return String.Format("Война закончилась поражением");
        }
    }
}