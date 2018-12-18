using System.Collections.Generic;

namespace PLArmyLife.Model.Interfaces.Adapter
{
    /// <summary>
    /// Интерфейс возможностей солдата
    /// </summary>
    interface IServiceMan
    {
        string[] CanICommand();

        string[] CanIEquipment();
    }
}
