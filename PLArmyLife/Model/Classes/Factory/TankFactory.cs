using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmyLife.Model.Classes.Compos;
using PLArmyLife.Model.Classes.Flyweight;
using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Interfaces.Factory;
using PLArmyLife.ViewModel.Model;

namespace PLArmyLife.Model.Classes.Factory
{
    /// <summary>
    /// Фабрика боевых танков
    /// </summary>
    class TankFactory : IDrawableFactory
    {
        public IDrawable CreateDrawable()
        {
            TankPlatoon platoon = new TankPlatoon();
            VField field = new VField();
            field.Add(new Tank().Draw(PicSize.Medium), true);
            field.Add(new Fuel().Draw(PicSize.Small).Offset(-20, 50), true);
            field.Add(new Ammo().Draw(PicSize.Small).Offset(25, 60), true);
            field.Add(new ZIP().Draw(PicSize.Small).Offset(70, 50), true);
            field.Add(new Solder("", "Командир").Draw(PicSize.VerySmall).Offset(20, -40), true);
            field.Add(new Solder("", "Водитель").Draw(PicSize.VerySmall).Offset(65, -30), true);
            field.Add(new Solder("", "Наводчик").Draw(PicSize.VerySmall).Offset(95, 10), true);
            IDrawable drawable = field;
            return drawable;
        }
    }
}