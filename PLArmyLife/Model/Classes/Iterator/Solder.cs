using PLArmyLife.Model.Classes.Delegate;
using PLArmyLife.Model.Classes.Singleton;
using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces;
using PLArmyLife.ViewModel.Interfaces;
using PLArmyLife.ViewModel.Model;

namespace PLArmyLife.Model.Classes.Iterator
{
    /// <summary>
    /// Солдат
    /// </summary>
    class Solder : Serviceman, ICopyable, IDrawable
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
            History.GetHistory().AddEvent(new Event("Создан солдат"));
            equipment = new HighLevelKnowledge();
            command = new LowRank();
            rank = ERank.Солдат;
            this.name = name;
            this.post = post;
        }

        public Solder()
        {
            History.GetHistory().AddEvent(new Event("Создан солдат"));
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

        public object Copy()
        {
            Solder solder = new Solder(name, post)
            {
                command = this.command,
                equipment = this.equipment,
                Greeting = this.Greeting,
                rank = this.rank,
            };
            return solder;
        }
    }
}