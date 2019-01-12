using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces.Compos;
using System;
using System.Collections.Generic;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Model;

namespace PLArmyLife.Model.Classes.Compos
{
    /// <summary>
    /// Топливо
    /// </summary>
    class Fuel : IItem, IDrawable
    {
        public List<string> Take(ESubdivision subdivision)
        {
            List<string> vs = new List<string>();
            vs.Add(String.Format("Вы взяли топливо"));
            return vs;
        }

        public VField Draw(PicSize size)
        {
            return new VField(VImages.Fuel, size, "Топливо");
        }
        public VField Draw()
        {
            return new VField(VImages.Fuel, PicSize.VerySmall, "Топливо");
        }
    }
}
