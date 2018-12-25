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
        public VObject(Point pos, BitmapImage image, string title = null, string msg = null)
        {
            this.image = image;
            this.title = title;
            this.msg = msg;
            this.pos = pos;
        }

        public BitmapImage image { get; }
        public string title { get; }
        public string msg { get; }
        public Point pos { get; }
    }
}
