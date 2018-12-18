using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Interfaces.Bridge
{
    /// <summary>
    /// План атаки при войне
    /// Implementor: определяет базовый интерфейс для конкретных реализаций.
    /// </summary>
    interface IPlan
    {
        /// <summary>
        /// Атаковать
        /// </summary>
        string Attack();
        /// <summary>
        /// Отступать
        /// </summary>
        string Retreat();
        /// <summary>
        /// Занять позицию
        /// </summary>
        string TakePosition();
        string Greeting { get; }
    }
}
