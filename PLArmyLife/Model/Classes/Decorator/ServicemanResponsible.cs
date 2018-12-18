using System;
using PLArmyLife.Model.Interfaces.Decorator;

namespace PLArmyLife.Model.Classes.Decorator
{
    /// <summary>
    /// Дежурный по части - ответственный за ситуацию
    /// ConcreteComponent - Конкретная реализация с новой функциональностью
    /// </summary>
    class ServicemanResponsible : ServicemanDecorator
    {
        public ServicemanResponsible(IEmergency serviceman) : base(serviceman)
        {
            this.Greeting = "Я Дежурный офицер";
        }

        public string MakeReport()
        {
            return String.Format(" Я несу ответственность за проишествие.");
        }
        /// <summary>
        /// Несет ответственность + доп. функции
        /// </summary>
        public override string FollowInstructionInCaseOfFire()
        {
            return MakeReport() + base.FollowInstructionInCaseOfFire();
        }
    }
}
