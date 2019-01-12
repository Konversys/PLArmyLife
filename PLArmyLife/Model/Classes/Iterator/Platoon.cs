using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces.Compos;
using PLArmyLife.Model.Interfaces.Iterator;
using System.Collections.Generic;
using System.Windows;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Model;
using PLArmyLife.Model.Classes.Singleton;

namespace PLArmyLife.Model.Classes.Iterator
{
    /// <summary>
    /// Взвод
    /// </summary>
    class Platoon : ISolderNumerable, IItem, IDrawable
    {
        /// <summary>
        /// Очистить список солдат
        /// </summary>
        public void Clear()
        {
            solders.Clear();
        }
        /// <summary>
        /// Приспособленец
        /// Задать Имя взвода и присоединиться
        /// </summary>
        public virtual string SetTitleAndConnect(string title)
        {
            this.title = title;
            return title;
        }
        /// <summary>
        /// Название взвода
        /// </summary>
        public string title { get; private set; }
        /// <summary>
        /// Список взвода
        /// </summary>
        List<Solder> solders;
        public Platoon()
        {
            History.GetHistory().AddEvent(new Event("Создан взвод"));
            this.solders = new List<Solder>();
        }
        public Platoon(string title)
        {
            History.GetHistory().AddEvent(new Event($"Создан взвод {title}"));
            this.solders = new List<Solder>();
            this.title = title;
        }
        /// <summary>
        /// Количество бойцов во взводе
        /// </summary>
        /// <returns></returns>
        public int GetSolderCount()
        {
            return solders.Count;
        }
        /// <summary>
        /// Количество бойцов
        /// </summary>
        int ISolderNumerable.Count
        {
            get { return solders.Count; }
        }
        /// <summary>
        /// Текущий солдат
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Solder this[int index]
        {
            get { return solders[index]; }
        }
        /// <summary>
        /// Создать итератор
        /// </summary>
        /// <returns></returns>
        public ISolderIterator CreateNumerator()
        {
            return new SolderNumerator(this);
        }
        /// <summary>
        /// Добавить солдата
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="post">Должность</param>
        public void AddSolder(string name, string post)
        {
            this.solders.Add(new Solder(name, post));
        }
        /// <summary>
        /// Удалить солдата
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="post">Должность</param>
        public void RemoveSolder(string name)
        {
            solders.RemoveAll(x => x.name == name);
        }

        List<IItem> components = new List<IItem>();
        public List<string> Take(ESubdivision subdivision = ESubdivision.Взвод)
        {
            List<string> list = new List<string>();
            foreach (var item in components)
            {
                list.AddRange(item.Take(subdivision - 1));
            }
            return list;
        }

        /// <summary>
        /// Добавить элемент
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(IItem item)
        {
            components.Add(item);
        }

        /// <summary>
        /// Удалить элемент
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItem(IItem item)
        {
            components.Remove(item);
        }


        public VField Draw(PicSize size)
        {
            VField field = new VField();
            int row = 0, x = 0, y = 0, dx = 70;
            foreach (var solder in solders)
            {
                field.Add(VImages.Solder, size, new Point(x, y), $"{solder.post}", $"{solder.name}");
                x += dx;
                row++;
                if (row == 3)
                {
                    row = 0;
                    x = 0;
                    y += dx;
                }
            }

            return field;
        }
        public VField Draw()
        {
            VField field = new VField();
            int row = 0, x = 0, y = 0, dx = 70;
            foreach (var solder in solders)
            {
                field.Add(VImages.Solder, PicSize.Small, new Point(x, y), $"{solder.post}", $"{solder.name}");
                x += dx;
                row++;
                if (row == 3)
                {
                    row = 0;
                    x = 0;
                    y += dx;
                }
            }

            return field;
        }
    }
}
