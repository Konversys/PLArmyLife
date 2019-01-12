using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using PLArmyLife.ViewModel.Interfaces;

namespace PLArmyLife.ViewModel.Model
{
    /// <summary>
    /// Объект View
    /// </summary>
    class VObject : IVObject
    {
        public VObject(BitmapImage image, PicSize size, string title = null, string msg = null)
        {
            this.image = image;
            this.title = title;
            this.msg = msg;
            this.size = size;
            pos = new Point(0, 0);
        }
        public VObject(BitmapImage image, Point pos, PicSize size, string title = null, string msg = null)
        {
            this.image = image;
            this.title = title;
            this.msg = msg;
            this.pos = pos;
            this.size = size;
        }
        /// <summary>
        /// Смещение объекта
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Offset(double x, double y)
        {
            this.pos = new Point(pos.X + x, pos.Y + y);
        }
        /// <summary>
        /// Смещение объекта
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="isHorizontal">Ось смещения в случае если точка уже занята</param>
        public void Offset(double value, bool isHorizontal)
        {
            if (isHorizontal)
                this.pos = new Point(pos.X + value, pos.Y);
            else
                this.pos = new Point(pos.X, pos.Y + value);
        }
        public BitmapImage image { get; }
        public string title { get; }
        public string msg { get; }
        public Point pos { get; private set; }
        public PicSize size { get; private set; }
    }
}
