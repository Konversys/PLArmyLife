using PLArmyLife.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PLArmyLife.Model.Classes.Compos;
using PLArmyLife.Model.Classes.Delegate;
using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.Model.Classes.Proxy;
using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces;
using PLArmyLife.Model.Interfaces.Compos;
using PLArmyLife.ViewModel.Interfaces.Factory;
using PLArmyLife.ViewModel.Model;

namespace PLArmyLifeLife
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string sb = "";
            IDrawableFactory drawableFactory = new TankFactory();
            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(50, 50).canvas);
            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(250, 50).canvas);
            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(450, 50).canvas);
            drawableFactory = new PlatoonFactory();
            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(100, 250).canvas);
            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(450, 250).canvas);
            Data.Text = sb;
        }
    }
}
