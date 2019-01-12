using PLArmyLife.Model.Enums;
using System.Collections.Generic;
using PLArmyLife.ViewModel.Interfaces;

namespace PLArmyLife.Model.Interfaces.Compos
{
    /// <summary>
    /// Предмет
    /// </summary>
    interface IItem : IDrawable
    {
        /// <summary>
        /// Взять предмет для...
        /// </summary>
        /// <param name="subdivision">Подразделение для предмета</param>
        List<string> Take(ESubdivision subdivision);
    }
}
