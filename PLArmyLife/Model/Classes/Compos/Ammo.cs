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
    class Ammo : IItem, IDrawable
    {
        public List<string> Take(ESubdivision subdivision)
        {
            History.GetHistory().AddEvent(new Event("Создан боезапас"));
            List<string> vs = new List<string>();
            vs.Add(String.Format("Вы взяли боезапас"));
            return vs;
        }
        public VField Draw(PicSize size)
        {
            return new VField(VImages.Ammo, size, "Боезапас");
        }
        public VField Draw()
        {
            return new VField(VImages.Ammo, PicSize.Small, "Боезапас");
        }
    }
}
