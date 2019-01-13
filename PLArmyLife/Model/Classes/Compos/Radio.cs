using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces.Compos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Model;
using PLArmyLife.Model.Classes.Singleton;

namespace PLArmyLife.Model.Classes.Compos
{
    /// <summary>
    /// Боезапас
    /// </summary>
    class Radio : IItem, IDrawable
    {
        public Radio()
        {
            History.GetHistory().AddEvent(new Event("Создана радиостанция"));
        }

        public List<string> Take(ESubdivision subdivision)
        {
            List<string> vs = new List<string>();
            vs.Add(String.Format("Вы взяли радиостанцию"));
            return vs;
        }
        public VField Draw(PicSize size)
        {
            return new VField(VImages.Radio, size, "Радиостанция");
        }
        public VField Draw()
        {
            return new VField(VImages.Radio, PicSize.Small, "Радиостанция");
        }
    }
}
