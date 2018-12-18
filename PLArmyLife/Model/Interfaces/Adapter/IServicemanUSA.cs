namespace PLArmyLife.Model.Interfaces.Adapter
{
    /// <summary>
    /// Интерфейс возможностей солдата США
    /// </summary>
    interface IServicemanUSA
    { 
        string Attack();
        string Retreat();
        string SetOrder();
        string GetOrder();
        string Repair();
        string Break();
    }
}
