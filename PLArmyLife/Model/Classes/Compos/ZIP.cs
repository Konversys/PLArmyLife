﻿using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces.Compos;
using System;
using System.Collections.Generic;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Model;

namespace PLArmyLife.Model.Classes.Compos
{
    /// <summary>
    /// Комплект ЗИП
    /// </summary>
    class ZIP : IItem, IDrawable
    {
        public List<string> Take(ESubdivision subdivision)
        {
            List<string> vs = new List<string>();
            vs.Add(String.Format("Вы взяли комплект ЗИП"));
            return vs;
        }
        public VField Draw(PicSize size)
        {
            return new VField(VImages.ZIP, size, "ЗИП");
        }
        public VField Draw()
        {
            return new VField(VImages.ZIP, PicSize.VerySmall, "ЗИП");
        }
    }
}
