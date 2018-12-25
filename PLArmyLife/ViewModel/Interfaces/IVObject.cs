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
    interface IVObject
    {
        BitmapImage image { get; }
        String title { get; }
        String msg { get; }
        Point pos { get; }

    }
}
