using PLArmyLife.Model.Interfaces.Delegate;
using System;

namespace PLArmyLife.Model.Classes.Delegate
{
    /// <summary>
    /// Мало знает
    /// </summary>
    class LowLevelKnowledge : IEquipment
    {
        public string Break()
        {
            return String.Format("     Я могу легко сломать технику");
        }

        public string Repair()
        {
            return String.Format("     Я не знаю как чинить технику");
        }
    }
}
