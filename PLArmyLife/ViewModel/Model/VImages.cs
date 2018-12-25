using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PLArmyLife.ViewModel.Model
{
    class VImages
    {
        /// <summary>
        /// Солдат
        /// </summary>
        public static readonly BitmapImage Solder = new BitmapImage(new Uri("D:/ASTU/7s/АПиПП/PLArmyLife/PLArmyLife/Images/solder.png", UriKind.Absolute));
        /// <summary>
        /// Танк
        /// </summary>
        public static readonly BitmapImage Tank = new BitmapImage(new Uri("D:/ASTU/7s/АПиПП/PLArmyLife/PLArmyLife/Images/tank.png", UriKind.Absolute));
        /// <summary>
        /// Боезапас
        /// </summary>
        public static readonly BitmapImage Ammo = new BitmapImage(new Uri("D:/ASTU/7s/АПиПП/PLArmyLife/PLArmyLife/Images/ammo.png", UriKind.Absolute));
        /// <summary>
        /// Топливо
        /// </summary>
        public static readonly BitmapImage Fuel = new BitmapImage(new Uri("D:/ASTU/7s/АПиПП/PLArmyLife/PLArmyLife/Images/fuel.png", UriKind.Absolute));
        /// <summary>
        /// Комплект ЗИП
        /// </summary>
        public static readonly BitmapImage ZIP = new BitmapImage(new Uri("D:/ASTU/7s/АПиПП/PLArmyLife/PLArmyLife/Images/zip.png", UriKind.Absolute));
    }
}
