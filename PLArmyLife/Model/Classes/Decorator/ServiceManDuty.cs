using System;
using PLArmyLife.Model.Interfaces.Decorator;

namespace PLArmyLife.Model.Classes.Decorator
{
    /// <summary>
    /// Дежурный - Отвечает за вещи в части
    /// ConcreteComponent - Конкретная реализация с новой функциональностью
    /// </summary>
    class ServiceManDuty : ServicemanDecorator
    {
        public ServiceManDuty(IEmergency serviceman) : base(serviceman)
        {
            this.Greeting = "Я Дежурный по казарме";
        }

        public string SaveItems()
        {
            return String.Format(" Я буду спасать вещи");
        }
        /// <summary>
        /// Выносит вещи + доп. функции
        /// </summary>
        public override string FollowInstructionInCaseOfFire()
        {
            return SaveItems() + base.FollowInstructionInCaseOfFire();
        }
    }
}
