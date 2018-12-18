using PLArmyLife.Model.Interfaces.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Iterator
{
    /// <summary>
    /// Перечеслитель
    /// </summary>
    class SolderNumerator : ISolderIterator
    {
        ISolderNumerable aggregate;
        int index;
        public SolderNumerator(ISolderNumerable aggregate)
        {
            this.aggregate = aggregate;
            this.index = 0;
        }
        /// <summary>
        /// Имеется ли еще солдат во взводе?
        /// </summary>
        /// <returns></returns>
        public bool HasNext()
        {
            return index < aggregate.Count;
        }
        /// <summary>
        /// Взять след. солдата
        /// </summary>
        /// <returns></returns>
        public Solder Next()
        {
            return aggregate[index++];
        }
    }
}
