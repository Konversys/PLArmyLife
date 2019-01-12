using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces.Compos;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Model;

namespace PLArmyLife.Model.Classes.Compos
{
    class Tank : IItem, IDrawable
    {
        public List<string> Take(ESubdivision subdivision)
        {
            List<string> vs = new List<string>();
            vs.Add(String.Format("Вы взяли танк"));
            return vs;
        }

        public VField Draw(PicSize size)
        {
            return new VField(VImages.Tank, size, "Танк");
        }
        public VField Draw()
        {
            return new VField(VImages.Tank, PicSize.Medium, "Танк");
        }
    }
}