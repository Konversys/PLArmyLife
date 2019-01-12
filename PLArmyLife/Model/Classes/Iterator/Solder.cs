using PLArmyLife.Model.Classes.Delegate;
using PLArmyLife.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Model;

namespace PLArmyLife.Model.Classes.Iterator
{
    /// <summary>
    /// Солдат
    /// </summary>
    class Solder : Serviceman
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string name { get; private set; }
        /// <summary>
        /// Должность
        /// </summary>
        public string post { get; private set; }
        /// <summary>
        /// Создать солдата
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="post">Должность</param>
        public Solder(string name, string post)
        {
            equipment = new HighLevelKnowledge();
            command = new LowRank();
            rank = ERank.Солдат;
            this.post = post;
            this.name = name;
        }
        public Solder()
        {
        }

        public virtual VField Draw()
        {
            return new VField(VImages.Solder, PicSize.Medium, $"{post}",
                $"{Greeting}");
        }

        public VField Draw(PicSize size)
        {
            return new VField(VImages.Solder, size, $"{post}",
                $"{Greeting}");
        }
    }
}
