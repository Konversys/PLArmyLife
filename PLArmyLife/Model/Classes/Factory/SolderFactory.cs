﻿using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.ViewModel.Interfaces;
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
    class SolderFactory
    {
        public IDrawable CreateDrawable()
        {
            return new Solder();
        }
    }
}