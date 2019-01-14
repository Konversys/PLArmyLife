using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Builder
{
    /// <summary>
    /// Билдер - конструктор
    /// </summary>
    class Builder
    {
        DrawableBuilder drawableBuilder;

        public Builder()
        {
        }
        public Builder(DrawableBuilder drawableBuilder)
        {
            this.drawableBuilder = drawableBuilder;
        }
        public VField BuildDrawable()
        {
            drawableBuilder.CreateDrawableBackground();
            drawableBuilder.CreateDrawableBody();
            drawableBuilder.CreateDrawableHead();
            return drawableBuilder.Field;  
        }
        public void SetDrawableBuilder(DrawableBuilder drawableBuilder)
        {
            this.drawableBuilder = drawableBuilder;
        }
    }
}
