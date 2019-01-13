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
    class Gun : IItem, IDrawable
    {
        public Gun()
        {
            History.GetHistory().AddEvent(new Event("Создана пушка"));
        }

        public List<string> Take(ESubdivision subdivision)
        {
            List<string> vs = new List<string>();
            vs.Add(String.Format("Вы взяли пушку"));
            return vs;
        }
        public VField Draw(PicSize size)
        {
            return new VField(VImages.Gun, size, "Пушка");
        }
        public VField Draw()
        {
            return new VField(VImages.Gun, PicSize.Small, "Пушка");
        }
    }
}
