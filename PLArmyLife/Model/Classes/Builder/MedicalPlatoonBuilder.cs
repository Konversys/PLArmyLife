using PLArmyLife.Model.Classes.Compos;
using PLArmyLife.Model.Classes.Factory;
using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Interfaces.Factory;
using PLArmyLife.ViewModel.Model;
using System.Windows.Media;

namespace PLArmyLife.Model.Classes.Builder
{
    /// <summary>
    /// Drawable Билдер медицинского взвода
    /// </summary>
    class MedicalPlatoonBuilder : DrawableBuilder
    {
        public override void CreateDrawableBackground()
        {
            Field.ChangeBackground(Brushes.LightSeaGreen);
        }

        public override void CreateDrawableBody()
        {
            IDrawableFactory drawableFactory = new PlatoonFactory();
            Field.Add(drawableFactory.CreateDrawable().Draw().Offset(0, 0), true);
        }

        public override void CreateDrawableHead()
        {
            Field.Add(new Airkid().Draw().Offset(0, 130), true);
            Field.Add(new Ammo().Draw().Offset(70, 130), true);
            Field.Add(new Airkid().Draw().Offset(140, 130), true);
        }
    }
}