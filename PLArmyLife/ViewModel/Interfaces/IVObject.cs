using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PLArmyLife.ViewModel.Interfaces
{
    /// <summary>
    /// Метаданные об объекте
    /// </summary>
    interface IVObject
    {
        BitmapImage image { get; }
        string title { get; }
        string msg { get; }
        Point pos { get; }

    }
}
