using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Interfaces.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Factory
{
    /// <summary>
    /// Фабрика солдат
    /// </summary>
    class SolderFactory : IDrawableFactory
    {
        public IDrawable CreateDrawable()
        {
            return new Solder();
        }
    }
}
