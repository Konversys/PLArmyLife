namespace PLArmyLife.Model.Interfaces
{
    interface IMilitaryStock
    {
        /// <summary>
        /// Взять еду
        /// </summary>
        /// <param name="count">Кол-во</param>
        string TakeFood(int count);
        /// <summary>
        /// Взять броню
        /// </summary>
        /// <param name="count">Кол-во</param>
        string TakeArmor(int count);
        /// <summary>
        /// Взять оружие
        /// </summary>
        /// <param name="count">Кол-во</param>
        string TakeWeapon(int count);
    }
}
