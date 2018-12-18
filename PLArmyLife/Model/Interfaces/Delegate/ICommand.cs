namespace PLArmyLife.Model.Interfaces.Delegate
{
    /// <summary>
    /// Командирские возможности
    /// </summary>
    interface ICommand
    {
        string GiveOrder();
        string ExecuteOrder();
    }
}
