using PLArmyLife.Model.Classes.Factory;
using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.Model.Classes.Prototype;
using PLArmyLife.Model.Classes.Singleton;
using PLArmyLife.ViewModel.Interfaces.Factory;
using PLArmyLife.ViewModel.Model;
using System.Windows;

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

            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(50, 50).Canvas);
            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(250, 50).Canvas);
            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(450, 50).Canvas);
            drawableFactory = new PlatoonFactory();
            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(100, 250).Canvas);
            field.Children.Add(drawableFactory.CreateDrawable().Draw().Offset(450, 250).Canvas);

            SolderPFactory prototype = new SolderPFactory(new Solder("Пикалыч", "Ком взвода"));
            field.Children.Add(prototype.MakeCopy().Draw(PicSize.Large).Offset(155, 400).Canvas);
            field.Children.Add(prototype.MakeCopy().Draw(PicSize.Large).Offset(505, 400).Canvas);

            foreach (var item in History.GetHistory().GetEvents())
            {
                sb += $"{item.Title}\n";
            }

            Data.Text = sb;
        }
    }
}