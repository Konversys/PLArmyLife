using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PLArmyLife.ViewModel.Interfaces
{
    interface IMove
    {
        void Move(Point from, Point to);
        void SetItem(Point point, Image texture, string title);
        void DeleteItem(string title);
        void DeleteItem(Point point);
    }
}
