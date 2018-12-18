using PLArmyLife.Model.Interfaces;
using PLArmyLife.Model.Interfaces.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Bridge
{
    /// <summary>
    /// Развитие войны
    /// Abstraction: определяет базовый интерфейс и хранит ссылку на объект Implementor.
    /// Выполнение операций в Abstraction делегируется методам объекта Implementor
    /// </summary>
    abstract class War
    {
        public IPlan plan { get; set; }
        public string Greeting { get; private set; }
        public War(IPlan plan)
        {
            this.Greeting = String.Format("Начинаем войну");
            this.plan = plan;
        }
        /// <summary>
        /// Атаковать
        /// </summary>
        public string Attack()
        {
            return plan.Attack();
        }
        /// <summary>
        /// Передышка/Занять позицию
        /// </summary>
        public string Respite()
        {
            return plan.TakePosition();
        }
        /// <summary>
        /// Нести потери
        /// </summary>
        public string BearALoss()
        {
            return plan.Retreat();
        }
        /// <summary>
        /// Отчет о статусе войны
        /// </summary>
        public abstract string Report();
    }
}
