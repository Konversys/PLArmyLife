using PLArmyLife.Model.Interfaces.Delegate;
using System;

namespace PLArmyLife.Model.Classes.Delegate
{
    /// <summary>
    /// Много знает
    /// </summary>
    class HighLevelKnowledge : IEquipment
    {
        public string Break()
        {
            return String.Format("Я слишком опытен чтобы ломать технику");
        }

        public string Repair()
        {
            return String.Format("Я могу легко починить технику");
        }
    }
}
