using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace PLArmyLife.ViewModel.Model
{
    class VHelper
    {
        public VHelper(Canvas field)
        {
            this.field = field;
            objects = new List<VObject>();
        }
        public Canvas field { get; private set; }
        public List<VObject> objects { get; private set; }
        public void ClearObjects()
        {
            objects.Clear();
        }
        /// <summary>
        /// Добавить объект
        /// </summary>
        /// <param name="image">Изображение</param>
        /// <param name="size">Размер пикчи</param>
        /// <param name="pos">Координаты</param>
        /// <param name="title">Название</param>
        /// <param name="msg">Сообщение</param>
        public void Add(BitmapImage image, PicSize size, Point pos, string title, string msg = null)
        {
            Canvas can = new Canvas
            {
                Background = new ImageBrush() {ImageSource = image},
                Margin = new Thickness() {Left = pos.X, Top = pos.Y},
                Width = (uint)size,
                Height = (uint)size
            };
            if (title != null)
            {
                TextBlock tLabel = new TextBlock()
                {
                    Foreground = Brushes.White,
                    FontSize = 20,
                    Effect = new DropShadowEffect() { BlurRadius = 10, Color = Colors.Black, ShadowDepth = 1 },
                    Text = title,
                };
                can.Children.Add(tLabel);
            }

            if (msg != null)
            {
                TextBlock mLabel = new TextBlock()
                {
                    Margin = new Thickness() { Top = 20 },
                    Foreground = Brushes.White,
                    FontSize = 14,
                    Effect = new DropShadowEffect() { BlurRadius = 10, Color = Colors.Black, ShadowDepth = 1 },
                    Text = msg,
                };
                can.Children.Add(mLabel);
            }
            field.Children.Add(can);
            objects.Add(new VObject(pos, image, title, msg));
        }
    }
}
