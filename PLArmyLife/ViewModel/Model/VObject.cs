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
            this.Image = image;
            this.Title = title;
            this.Message = msg;
            this.Size = size;
            Position = new Point(0, 0);
        }
        public VObject(BitmapImage image, Point pos, PicSize size, string title = null, string msg = null)
        {
            this.Image = image;
            this.Title = title;
            this.Message = msg;
            this.Position = pos;
            this.Size = size;
        }
        /// <summary>
        /// Смещение объекта
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Offset(double x, double y)
        {
            this.Position = new Point(Position.X + x, Position.Y + y);
        }
        /// <summary>
        /// Смещение объекта
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="isHorizontal">Ось смещения в случае если точка уже занята</param>
        public void Offset(double value, bool isHorizontal)
        {
            if (isHorizontal)
                this.Position = new Point(Position.X + value, Position.Y);
            else
                this.Position = new Point(Position.X, Position.Y + value);
        }
        public BitmapImage Image { get; }
        public string Title { get; }
        public string Message { get; }
        public Point Position { get; private set; }
        public PicSize Size { get; private set; }
    }
}
