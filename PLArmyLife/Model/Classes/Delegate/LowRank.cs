using PLArmyLife.Model.Interfaces.Delegate;
using System;

namespace PLArmyLife.Model.Classes.Delegate
{
    /// <summary>
    /// Выполняет приказы
    /// </summary>
    class LowRank : ICommand
    {
        public string ExecuteOrder()
        {
            return String.Format("     Мое звание слишком маленькое чтобы отдавать приказы");
        }

        public string GiveOrder()
        {
            return String.Format("     Я всегда готов выполнить приказ");
        }
    }
}
