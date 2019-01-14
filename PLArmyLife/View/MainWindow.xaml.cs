using PLArmyLife.Model.Classes.Builder;
using PLArmyLife.Model.Classes.Factory;
using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.Model.Classes.ObjectPool;
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

            #region Factory
            /*
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
                    */
            #endregion

            #region Builder
            /*
            Builder builder = new Builder();

            builder.SetDrawableBuilder(new TankPlatoonBuilder());
            field.Children.Add(builder.BuildDrawable().Draw().Offset(50, 50).Canvas);

            builder.SetDrawableBuilder(new AirdefensePlatoonBuilder());
            field.Children.Add(builder.BuildDrawable().Draw().Offset(50,200).Canvas);

            builder.SetDrawableBuilder(new MedicalPlatoonBuilder());
            field.Children.Add(builder.BuildDrawable().Draw().Offset(300, 200).Canvas);

            builder.SetDrawableBuilder(new ConnectionPlatoonBuilder());
            field.Children.Add(builder.BuildDrawable().Draw().Offset(550, 200).Canvas);
            */
            #endregion

            #region Pool
            /*
            SolderPool solderPool = new SolderPool();

            solderPool.GetPooledSolder();
            Solder solder2 = solderPool.GetPooledSolder();
            Solder solder3 = solderPool.GetPooledSolder();
            solderPool.GetPooledSolder();
            field.Children.Add(solderPool.GetDrawableUsed().Draw().Offset(10, 10).Canvas);
            field.Children.Add(solderPool.GetDrawableFree().Draw().Offset(400, 10).Canvas);

            solderPool.ReleasePooledSolder(solder2);
            solderPool.ReleasePooledSolder(solder3);
            field.Children.Add(solderPool.GetDrawableUsed().Draw().Offset(10, 100).Canvas);
            field.Children.Add(solderPool.GetDrawableFree().Draw().Offset(400, 100).Canvas);

            solderPool.GetPooledSolder();
            field.Children.Add(solderPool.GetDrawableUsed().Draw().Offset(10, 200).Canvas);
            field.Children.Add(solderPool.GetDrawableFree().Draw().Offset(400, 200).Canvas);
            */
            #endregion

            foreach (var item in History.GetHistory().GetEvents())
            {
                sb += $"{item.Title}\n";
            }
            Data.Text = sb;
        }
    }
}