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
            VHelper vHelper = new VHelper(field);
            vHelper.Add(VImages.Solder, PicSize.VeryLarge, new Point(100, 20), "Генерал", "Сдаем 600 рублей на жалюзи");
            vHelper.Add(VImages.Solder, PicSize.Medium, new Point(320, 70), "Солдат", "сук(( пиздец((09(");
            field = vHelper.field;
        }
    }
}
