using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Interfaces.Factory;
using PLArmyLife.ViewModel.Model;
using System.Collections.Generic;
using System.Windows.Controls;

namespace PLArmyLife.Model.Classes.Builder
{
    /// <summary>
    /// Drawable Билдер
    /// </summary>
    abstract class DrawableBuilder
    {
        public VField Field { get; private set; }
        public List<VObject> Objects { get; private set; }

        protected DrawableBuilder()
        {
            Field = new VField();
            Objects = new List<VObject>();
        }
        /// <summary>
        /// Билдер головы - начальства и ключевых предметов
        /// </summary>
        public abstract void CreateDrawableHead();
        /// <summary>
        /// Билдер тела - основной состав
        /// </summary>
        public abstract void CreateDrawableBody();
        /// <summary>
        /// Билдер фона
        /// </summary>
        public abstract void CreateDrawableBackground();
        /// <summary>
        /// Возвращает готовое поле заданного класса
        /// </summary>
        /// <returns></returns>
        public Canvas GetField()
        {
            return Field.Canvas;
        }
    }
}