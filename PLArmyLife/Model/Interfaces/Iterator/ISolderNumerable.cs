using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Interfaces.Iterator
{
    /// <summary>
    /// Определяет интерфейс для создания объекта-итератора
    /// </summary>
    interface ISolderNumerable
    {
        ISolderIterator CreateNumerator();
        int Count { get; }
        Solder this[int index] { get; }
    }
}
