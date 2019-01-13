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
using PLArmyLife.ViewModel.Interfaces;

namespace PLArmyLife.ViewModel.Model
{
    class VField : IDrawable
    {
        public VField(BitmapImage image, PicSize size, string title = null, string msg = null)
        {
            Objects = new List<VObject>();
            Canvas = new Canvas();
            this.Add(image, size, new Point(0,0), title, msg);
        }
        public VField(BitmapImage image, PicSize size, Point point, string title = null, string msg = null)
        {
            Objects = new List<VObject>();
            Canvas = new Canvas();
            this.Add(image, size, point, title, msg);
        }
        public VField()
        {
            Objects = new List<VObject>();
            Canvas = new Canvas();
        }

        public Canvas Canvas { get; private set; }
        public List<VObject> Objects { get; private set; }
        public void ClearObjects()
        {
            Objects.Clear();
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
                    FontSize = 9,
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
                    FontSize = 7,
                    Effect = new DropShadowEffect() { BlurRadius = 10, Color = Colors.Black, ShadowDepth = 1 },
                    Text = msg,
                };
                can.Children.Add(mLabel);
            }
            Canvas.Children.Add(can);
            Objects.Add(new VObject(image, pos, size, title, msg));
        }
        /// <summary>
        /// Добавить объект
        /// </summary>
        /// <param name="image">Изображение</param>
        /// <param name="size">Размер пикчи</param>
        /// <param name="pos">Координаты</param>
        /// <param name="title">Название</param>
        /// <param name="msg">Сообщение</param>
        public void Add(BitmapImage image, PicSize size, string title, string msg = null)
        {
            Point pos = new Point(0, 0);
            Add(image, size, pos, title, title);
        }
        /// <summary>
        /// Добавить объект
        /// </summary>
        /// <param name="obj">Объект</param>
        /// <param name="isHorizontal">Ось смещения в случае если точка уже занята</param>
        public void Add(VField obj, bool isHorizontal)
        {
            foreach (var item in obj.Objects)
            {
                while (Objects.Where(x => x.Position.X == item.Position.X && x.Position.Y == item.Position.Y).Count() != 0)
                {
                    switch (item.Size)
                    {
                        case PicSize.VerySmall:
                            item.Offset(40, isHorizontal);
                            break;
                        case PicSize.Small:
                            item.Offset(55, isHorizontal);
                            break;
                        case PicSize.Medium:
                            item.Offset(70, isHorizontal);
                            break;
                        case PicSize.Large:
                            item.Offset(85, isHorizontal);
                            break;
                        case PicSize.VeryLarge:
                            item.Offset(100, isHorizontal);
                            break;
                        default:
                            item.Offset(1, isHorizontal);
                            break;
                    }
                    obj.Canvas.Margin = new Thickness() {Left = item.Position.X, Top = item.Position.Y};
                }
            }
            Canvas.Children.Add(obj.Canvas);
            Objects.AddRange(obj.Objects);
        }
        /// <summary>
        /// Смещение объекта
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public VField Offset(double x, double y)
        {
            foreach (var item in Objects)
            {
                item.Offset(x, y);
            }

            Canvas.Margin = new Thickness() {Left = Canvas.Margin.Left + x, Top = Canvas.Margin.Top + y};
            return this;
        }
        /// <summary>
        /// Нарисовать объект
        /// </summary>
        /// <returns></returns>
        public VField Draw()
        {
            return this;
        }
        /// <summary>
        /// Нарисовать объект
        /// </summary>
        /// <param name="size">Размер</param>
        /// <returns></returns>
        public VField Draw(PicSize size)
        {
            return this;
        }
        public void ChangeBackground(SolidColorBrush brush)
        {
            Canvas.Background = brush;
        }
    }
}
