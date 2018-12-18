namespace PLArmyLife.Model.Interfaces.Decorator
{
    /// <summary>
    /// Случаи ЧП
    /// Component - абстрактный класс, который определяет интерфейс для наследуемых объектов
    /// </summary>
    interface IEmergency
    {
        /// <summary>
        /// Инструкции на случай пожара
        /// </summary>
        string FollowInstructionInCaseOfFire();
        string Greeting { get; }
    }
}
