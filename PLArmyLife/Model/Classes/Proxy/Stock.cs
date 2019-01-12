using PLArmyLife.Model.Interfaces;
using System;
using PLArmyLife.Model.Classes.Singleton;

namespace PLArmyLife.Model.Classes.Proxy
{
    class Stock : IMilitaryStock
    {
        int countArmor;
        int countFood;
        int countWeapon;

        public Stock(int countArmor, int countFood, int countWeapon)
        {
            History.GetHistory().AddEvent(new Event("Создание склада"));
            this.countArmor = countArmor;
            this.countFood = countFood;
            this.countWeapon = countWeapon;
        }

        public string TakeArmor(int count)
        {
            if (this.countArmor - count >= 0)
            {
                this.countArmor -= count;
                return String.Format("Вы взяли {0} брони. Осталось на складе - {1}", count, this.countArmor);
            }
            else
            {
                return RefuseNoCount();
            }
        }

        public string TakeFood(int count)
        {
            if (this.countFood - count >= 0)
            {
                this.countFood -= count;
                return String.Format("Вы взяли {0} еды. Осталось на складе - {1}", count, this.countFood);
            }
            else
            {
                return RefuseNoCount();
            }
        }

        public string TakeWeapon(int count)
        {
            if (this.countWeapon - count >= 0)
            {
                this.countWeapon -= count;
                return String.Format("Вы взяли {0} оружия. Осталось на складе - {1}", count, this.countWeapon);
            }
            else
            {
                return RefuseNoCount();
            }
        }

        string RefuseNoCount()
        {
            History.GetHistory().AddEvent(new Event("Отказ склада из-за отстутствия предметов"));
            return "Заданного кол-ва предметов нет на складе";
        }
    }
}
