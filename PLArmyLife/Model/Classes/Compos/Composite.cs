﻿using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces.Compos;
using System;
using System.Collections.Generic;

namespace PLArmyLife.Model.Classes.Compos
{
    /// <summary>
    /// Список подразделений и выданных им предметов
    /// Представляет компонент, который может содержать другие компоненты и реализует механизм для их добавления и удаления
    /// </summary>
    class Composite : IItem
    { 
        /// <summary>
        /// Хранит компоненты
        /// </summary>
        List<IItem> components = new List<IItem>();
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
        /// <summary>
        /// Взять выданные подразделению предметы
        /// </summary>
        /// <param name="subdivision">Подразделение</param>
        public List<string> Take(ESubdivision subdivision = ESubdivision.Рота)
        {
            List<string> list = new List<string>();
            switch (subdivision)
            {
                case ESubdivision.Военнослущащий:
                    list.Add(String.Format("             Выдать предметы: {0}", subdivision));
                    break;
                case ESubdivision.Танк:
                    list.Add(String.Format("         Выдать предметы: {0}", subdivision));
                    break;
                case ESubdivision.Взвод:
                    list.Add(String.Format("     Выдать предметы: {0}", subdivision));
                    break;
                case ESubdivision.Рота:
                    list.Add(String.Format(" Выдать предметы: {0}", subdivision));
                    break;
                case ESubdivision.Батальен:
                    list.Add(String.Format("Выдать предметы: {0}", subdivision));
                    break;
                case ESubdivision.Полк:
                    list.Add(String.Format("Выдать предметы: {0}", subdivision));
                    break;
                default:
                    list.Add(String.Format("Выдать предметы: {0}", subdivision));
                    break;
            }
            foreach (var item in components)
            {
                if (subdivision - 1 > 0)
                {
                    list.AddRange(item.Take(subdivision - 1));
                }
            }
            return list;
        }
    }
}
