using PLArmyLife.Model.Interfaces.AbstractFactory;
using PLArmyLife.Model.Interfaces.Bridge;
using System;

namespace PLArmyLife.Model.Classes.Bridge
{
    /// <summary>
    /// Хороший исход войны
    /// Уточненная абстракция
    /// </summary>
    class GoodConditions : War, ICondition
    {
        public GoodConditions(IPlan plan) : base(plan)
        {
        }

        public override string Report()
        {
            return String.Format("Война закончилась победой");
        }
    }
}