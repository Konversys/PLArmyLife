﻿using PLArmyLife.Model.Classes.Delegate;
using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace PLArmyLife.Model.Classes.Proxy
{
    class ProxyStock : IMilitaryStock
    {
        ERank rank { get; set; }
        Stock stock { get; set; }

        /// <summary>
        /// Прийти на склад
        /// </summary>
        /// <param name="rank">Ваш ранг</param>
        /// <param name="countArmor">Кол-во брони на складе</param>
        /// <param name="countFood">Кол-во еды на складе</param>
        /// <param name="countWeapon">Кол-во оружия на складе</param>
        public ProxyStock(ERank rank, int countArmor, int countFood, int countWeapon)
        {
            this.stock = new Stock(countArmor, countFood, countWeapon);
            this.rank = rank;
        }
        /// <summary>
        /// Прийти на склад
        /// </summary>
        /// <param name="serviceman">Военнослужащий</param>
        /// <param name="countArmor">Кол-во брони на складе</param>
        /// <param name="countFood">Кол-во еды на складе</param>
        /// <param name="countWeapon">Кол-во оружия на складе</param>
        public ProxyStock(Serviceman serviceman, int countArmor, int countFood, int countWeapon)
        {
            this.stock = new Stock(countArmor, countFood, countWeapon);
            this.rank = serviceman.rank;
        }
        /// <summary>
        /// Взять броню
        /// </summary>
        /// <param name="count">Кол-во</param>
        public string TakeArmor(int count)
        {
            ERank allowRank = ERank.Lieutenant;
            string ret = String.Format("Вы {0} ~ {1}: Броня - ", rank, allowRank);
            if (rank >= allowRank)
            {
                return ret + stock.TakeArmor(count);
            }
            else
            {
                return ret + RefuseLowRank();
            }
        }
        /// <summary>
        /// Взять еду
        /// </summary>
        /// <param name="count">Кол-во</param>
        public string TakeFood(int count)
        {
            ERank allowRank = ERank.Sergeant;
            string ret = String.Format("Вы {0} ~ {1}: Еда - ", rank, allowRank);
            if (rank >= allowRank)
            {
                return ret + stock.TakeFood(count);
            }
            else
            {
                return ret + RefuseLowRank();
            }
        }
        /// <summary>
        /// Взять оружие
        /// </summary>
        /// <param name="count">Кол-во</param>
        public string TakeWeapon(int count)
        {
            ERank allowRank = ERank.Major;
            string ret = String.Format("Вы {0} ~ {1}: Оружие - ", rank, allowRank);
            if (rank >= allowRank)
            {
                return ret + stock.TakeWeapon(count);
            }
            else
            {
                return ret + RefuseLowRank();
            }
        }

        string RefuseLowRank()
        {
            return "Ваш ранг слишком низкий для получения этого предмета";
        }
    }
}
