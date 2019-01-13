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
    /// Drawable Билдер такового взвода
    /// </summary>
    class TankPlatoonBuilder : DrawableBuilder
    {
        public override void CreateDrawableBackground()
        {
            Field.ChangeBackground(Brushes.LightGray);
        }

        public override void CreateDrawableBody()
        {
            IDrawableFactory drawableFactory = new TankFactory();
            Field.Add(drawableFactory.CreateDrawable().Draw().Offset(0, 0), true);
            Field.Add(drawableFactory.CreateDrawable().Draw().Offset(180, 00), true);
            Field.Add(drawableFactory.CreateDrawable().Draw().Offset(360, 00), true);
        }

        public override void CreateDrawableHead()
        {
        }
    }
}