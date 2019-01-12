using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmyLife.Model.Classes.Iterator;

namespace PLArmyLife.ViewModel.Interfaces.Factory
{
    /// <summary>
    /// Фабрика взводов
    /// </summary>
    class PlatoonFactory : IDrawableFactory
    {
        public IDrawable CreateDrawable()
        {
            Platoon platoon = new Platoon("Взвод");
            platoon.AddSolder("Боец 1", "Ст. стрелок");
            platoon.AddSolder("Боец 2", "Гранатометчик");
            platoon.AddSolder("Боец 3", "Помощник гр.");
            platoon.AddSolder("Боец 4", "Стрелок");
            platoon.AddSolder("Боец 6", "Пулеметчик");
            platoon.AddSolder("Боец 7", "Снайпер");
            IDrawable drawable = platoon;
            return drawable;
        }
    }
}
