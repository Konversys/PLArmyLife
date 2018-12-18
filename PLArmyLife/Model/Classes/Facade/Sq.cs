using PLArmyLife.Model.Classes.Compos;
using PLArmyLife.Model.Classes.Flyweight;
using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces.Compos;
using PLArmyLife.Model.Interfaces.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmyLife.Model.Classes.Facade
{
    /// <summary>
    /// Рота
    /// Фасад, который через свои методы делегирует выполнение работы компонентам и их методам.
    /// </summary>
    class Sq
    {
        public Sq()
        {
            this.sq = new List<Platoon>();
        }
        /// <summary>
        /// Подсчитать кол-во бойцов в роте
        /// </summary>
        /// <returns></returns>
        public int GetSolderCount()
        {
            int count = 0;
            foreach (var item in sq)
            {
                count += item.GetSolderCount();
            }
            return count;
        }

        List<Platoon> sq { get; set; }
        /// <summary>
        /// Собрать роту
        /// </summary>
        public List<string> Equip()
        {
            List<string> vs = new List<string>();
            PlatoonFactory platoonFactory = new PlatoonFactory();
            RollCall rollCall = new RollCall();
            Composite tank = new Composite();

            tank.AddItem(new Ammo());
            tank.AddItem(new Fuel());
            tank.AddItem(new ZIP());

            Platoon p2si13 = new Platoon();
            p2si13 = platoonFactory.GetPlatoonClear("Танкисты");
            vs.Add(p2si13.SetTitleAndConnect("2СИ-13"));

            p2si13.AddItem(tank);
            p2si13.AddItem(tank);
            p2si13.AddItem(tank);

            p2si13.AddSolder("Барсуков", "Механик водитель 1-го танка");
            p2si13.AddSolder("Горбунцов", "Наводчик 1-го танка");
            p2si13.AddSolder("Бердюгин", "Командир экипажа 1-го танка");
            
            p2si13.AddSolder("Алексеев", "Механик водитель 2-го танка");
            p2si13.AddSolder("Крыловский", "Наводчик 2-го танка");
            p2si13.AddSolder("Астапов", "Командир экипажа 2-го танка");
            
            p2si13.AddSolder("Рудько", "Механик водитель 3-го танка");
            p2si13.AddSolder("Чеконов", "Наводчик 3-го танка");
            p2si13.AddSolder("Татьков", "Командир экипажа 3-го танка");
            vs.AddRange(rollCall.Begin(p2si13));

            sq.Add(p2si13);

            Platoon p1t16 = new Platoon();
            p1t16 = platoonFactory.GetPlatoonClear("Танкисты");
            vs.Add(p1t16.SetTitleAndConnect("1Т-16"));

            p1t16.AddItem(tank);
            p1t16.AddItem(tank);
            p1t16.AddItem(tank);
            
            p1t16.AddSolder("Худяков", "Механик водитель 1-го танка");
            p1t16.AddSolder("Попцов", "Наводчик 1-го танка");
            p1t16.AddSolder("Логинов", "Командир экипажа 1-го танка");
            
            p1t16.AddSolder("Михельсон", "Механик водитель 2-го танка");
            p1t16.AddSolder("Дроздов", "Наводчик 2-го танка");
            p1t16.AddSolder("Вяткин", "Командир экипажа 2-го танка");
            
            p1t16.AddSolder("Андреев", "Механик водитель 3-го танка");
            p1t16.AddSolder("Гринько", "Наводчик 3-го танка");
            p1t16.AddSolder("Свиридов", "Командир экипажа 3-го танка");

            vs.AddRange(rollCall.Begin(p1t16));
            sq.Add(p1t16);

            Platoon p2si15 = new Platoon();
            p2si15 = platoonFactory.GetPlatoonClear("Танкисты");
            vs.Add(p2si15.SetTitleAndConnect("2СИ-15"));
            
            p2si15.AddItem(tank);
            p2si15.AddItem(tank);
            p2si15.AddItem(tank);
            
            p2si15.AddSolder("Халилов", "Механик водитель 1-го танка");
            p2si15.AddSolder("Нагель", "Наводчик 1-го танка");
            p2si15.AddSolder("Черных", "Командир экипажа 1-го танка");
            
            p2si15.AddSolder("Красненко", "Механик водитель 2-го танка");
            p2si15.AddSolder("Рысьянов", "Наводчик 2-го танка");
            p2si15.AddSolder("Рыжков", "Командир экипажа 2-го танка");
           
            p2si15.AddSolder("Тычков", "Механик водитель 3-го танка");
            p2si15.AddSolder("Маркевцев", "Наводчик 3-го танка");
            p2si15.AddSolder("Даулетович", "Командир экипажа 3-го танка");

            vs.AddRange(rollCall.Begin(p2si15));
            sq.Add(p2si15);

            foreach (var item in sq)
            {
                vs.AddRange(item.Take());
            }
            return vs;
        }
        /// <summary>
        /// Добавить доп. взводы
        /// </summary>
        public List<string> AddSubPlatoon()
        {
            List<string> vs = new List<string>();
            PlatoonFactory platoonFactory = new PlatoonFactory();
            Platoon platoon = platoonFactory.GetPlatoonClear("Артиллеристы");
            vs.Add(platoon.SetTitleAndConnect("5F-13"));
            sq.Add(platoon);
            platoon = platoonFactory.GetPlatoon("Медицинский");
            vs.Add(platoon.SetTitleAndConnect("5М-17"));
            sq.Add(platoon);
            platoon = platoonFactory.GetPlatoon("Связисты");
            vs.Add(platoon.SetTitleAndConnect("3C-17"));
            sq.Add(platoon);
            return vs;
        }
    }
}
