using PLArmyLife.Model.Classes.Compos;
using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.Model.Classes.Singleton;
using PLArmyLife.Model.Interfaces.Compos;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.ObjectPool
{
    /// <summary>
    /// ObjectPool - Пул солдат занятых/незанятых делом
    /// </summary>
    class SolderPool
    {
        /// <summary>
        /// Счетчик бойцов
        /// </summary>
        static int count = 0;
        /// <summary>
        /// Максимально бойцов в пуле;
        /// </summary>
        static readonly int max = 9;
        List<Solder> free = new List<Solder>();
        List<Solder> used = new List<Solder>();

        /// <summary>
        /// Получить незанятого бойца
        /// </summary>
        /// <returns></returns>
        public Solder GetPooledSolder()
        {
            if (free.Count == 0)
            {
                if (used.Count + free.Count > 9)
                    return null;
                Solder solder = new Solder("", $"Боец {++count}");
                used.Add(solder);
                History.GetHistory().AddEvent(new Event($"Солдат {count} добавлен в пул"));
                return solder;
            }
            else
            {
                Solder solder = free.First();
                used.Add(solder);
                free.RemoveAt(0);
                History.GetHistory().AddEvent(new Event($"Солдат {count} взят из пула"));
                return solder;
            }
        }

        /// <summary>
        /// Отправить бойца на отдых
        /// </summary>
        /// <returns></returns>
        public void ReleasePooledSolder(Solder solder)
        {
            if (free.Contains(solder) || !used.Contains(solder))
            {
                return;
            }
            used.Remove(solder);
            free.Add(solder);
            History.GetHistory().AddEvent(new Event($"Солдат {count} возвращен в пул"));
        }
        /// <summary>
        /// Draw всех свободных бойцов
        /// </summary>
        /// <returns></returns>
        public IDrawable GetDrawableFree()
        {
            VField field = new VField();
            foreach (var item in free)
            {
                field.Add(item.Draw(), true);
            }
            return field;
        }
        /// <summary>
        /// Draw всех используемых бойцов
        /// </summary>
        /// <returns></returns>
        public IDrawable GetDrawableUsed()
        {
            VField field = new VField();
            foreach (var item in used)
            {
                field.Add(item.Draw(), true);
            }
            return field;
        }
    }
}
