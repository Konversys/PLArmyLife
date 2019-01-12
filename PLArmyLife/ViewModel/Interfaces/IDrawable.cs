using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmyLife.ViewModel.Model;

namespace PLArmyLife.ViewModel.Interfaces
{
    /// <summary>
    /// Отображаемый объект
    /// </summary>
    interface IDrawable
    {
        VField Draw(PicSize size);
        VField Draw();
    }
}
