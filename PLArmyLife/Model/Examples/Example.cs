using PLArmyLife.Model.Classes.Adapter;
using PLArmyLife.Model.Classes.Bridge;
using PLArmyLife.Model.Classes.Compos;
using PLArmyLife.Model.Classes.Decorator;
using PLArmyLife.Model.Classes.Delegate;
using PLArmyLife.Model.Classes.Facade;
using PLArmyLife.Model.Classes.Flyweight;
using PLArmyLife.Model.Classes.Iterator;
using PLArmyLife.Model.Classes.Proxy;
using PLArmyLife.Model.Enums;
using PLArmyLife.Model.Interfaces;
using PLArmyLife.Model.Interfaces.Compos;
using PLArmyLife.Model.Interfaces.Decorator;
using System;
using System.Collections.Generic;

namespace PLArmyLife.Model.Examples
{
    class Example
    {
        /// <summary>
        /// Прокси
        /// </summary>
        public static void GoProxyStock()
        {
            Serviceman serviceman = new ExperiencedOfficer();
            IMilitaryStock militaryStock = new ProxyStock(serviceman, 100, 20, 15);
            Print(militaryStock.TakeArmor(80));
            Print(militaryStock.TakeArmor(10));
            Print(militaryStock.TakeArmor(20));
            Print(militaryStock.TakeFood(30));
            Print(militaryStock.TakeFood(10));
            Print(militaryStock.TakeWeapon(5));
            Print(militaryStock.TakeWeapon(20));
            Console.ReadKey();
        }
        /// <summary>
        /// Делегирование
        /// </summary>
        public static void GoDelegateServiceman()
        {
            Serviceman serviceman;

            serviceman = new Conscript();
            Print(serviceman.Greeting);
            Print(serviceman.CanICommand());
            Console.WriteLine();
            Print(serviceman.CanIEquipment());
            Console.WriteLine();
            serviceman = new ExperiencedOfficer();
            Print(serviceman.Greeting);
            Print(serviceman.CanICommand());
            Console.WriteLine();
            Print(serviceman.CanIEquipment());
            Console.WriteLine();
            serviceman = new ContractTechnician();
            Print(serviceman.Greeting);
            Print(serviceman.CanICommand());
            Console.WriteLine();
            Print(serviceman.CanIEquipment());
            Console.ReadKey();
        }
        /// <summary>
        /// Адаптер
        /// </summary>
        public static void GoAdapterRusConscriptUSA()
        {
            Serviceman serviceman = new Conscript();
            Print(serviceman.Greeting);
            Print(serviceman.CanICommand());
            Print(serviceman.CanIEquipment());
            Console.WriteLine();
            RusificatedConscriptUSA rusificated = new RusificatedConscriptUSA();
            Print(rusificated.Greeting);
            Print(rusificated.CanICommand());
            Print(rusificated.CanIEquipment());
            Console.ReadKey();
        }
        /// <summary>
        /// Декоратор
        /// </summary>
        public static void GoDecoratorFire()
        {
            IEmergency serviceman = new ServicemanResponsible(new ServiceManDuty(new ExperiencedOfficer()));
            Print(serviceman.Greeting);
            Print(serviceman.FollowInstructionInCaseOfFire());
            Console.WriteLine();

            serviceman = new ServiceManDuty(new ContractTechnician());
            Print(serviceman.Greeting);
            Print(serviceman.FollowInstructionInCaseOfFire());
            Console.WriteLine();

            serviceman = new Conscript();
            Print(serviceman.Greeting);
            Print(serviceman.FollowInstructionInCaseOfFire());
            Console.WriteLine();

            serviceman = new ServiceManDuty(new ExperiencedOfficer());
            Print(serviceman.Greeting);
            Print(serviceman.FollowInstructionInCaseOfFire());

            Console.ReadKey();
        }
        /// <summary>
        /// Компоновщик
        /// </summary>
        public static void GoCompositeItem()
        {
            IItem ammo = new Ammo();
            IItem fuel = new Fuel();
            IItem zip = new ZIP();

            Composite tank = new Composite();
            tank.AddItem(ammo);
            tank.AddItem(ammo);
            tank.AddItem(fuel);
            tank.AddItem(zip);

            Composite platoon = new Composite();
            platoon.AddItem(tank);
            platoon.AddItem(tank);
            platoon.AddItem(tank);

            Composite sq = new Composite();
            sq.AddItem(platoon);
            sq.AddItem(platoon);
            sq.AddItem(platoon);
            sq.AddItem(platoon);

            Print(sq.Take(ESubdivision.Рота));

            Console.ReadKey();
        }
        /// <summary>
        /// Итератор
        /// </summary>
        public static void GoIteratorPlatoonRollCall()
        {
            Platoon platoon = new Platoon("2СИ-15");
            platoon.AddSolder("Халилов ", "Старший стрелок");
            platoon.AddSolder("Одилов  ", "Гранатометчик");
            platoon.AddSolder("Шарков  ", "Помощник гранатометчика");
            platoon.AddSolder("Лепезин ", "Стрелок");
            platoon.AddSolder("Дадашев ", "Стрелок");
            platoon.AddSolder("Нагель  ", "Пулеметчик");
            platoon.AddSolder("Андрюков", "Снайпер");

            RollCall rollCall = new RollCall();
            Print(rollCall.Begin(platoon));

            Console.ReadKey();
        }
        /// <summary>
        /// Мост
        /// </summary>
        public static void GoBridgeStartWar()
        {
            Platoon platoon = new Platoon("2СИ-15");
            platoon.AddSolder("Халилов ", "Старший стрелок");
            platoon.AddSolder("Одилов  ", "Гранатометчик");
            platoon.AddSolder("Шарков  ", "Помощник гранатометчика");
            platoon.AddSolder("Лепезин ", "Стрелок");
            platoon.AddSolder("Дадашев ", "Стрелок");
            platoon.AddSolder("Нагель  ", "Пулеметчик");
            platoon.AddSolder("Андрюков", "Снайпер");

            RollCall rollCall = new RollCall();
            Print(rollCall.Begin(platoon));

            Console.WriteLine("\nВзвод {0} готов к войне:\n", platoon.title);

            War war = new GoodConditions(new PlanA());
            Print(war.plan.Greeting);
            Print(war.Greeting);
            Print(war.Attack());
            Print(war.Respite());
            Print(war.BearALoss());
            war.plan = new PlanB();
            Print(war.plan.Greeting);
            Print(war.Greeting);
            Print(war.Respite());
            Print(war.Attack());
            Print(war.Report());

            Console.ReadKey();
        }
        /// <summary>
        /// Приспособленец
        /// </summary>
        public static void GoFlyweightPlatoonSpecialty()
        {
            PlatoonFactory platoonFactory = new PlatoonFactory();
            Platoon platoon = platoonFactory.GetPlatoon("Танкисты");
            if (platoon != null)
            {
                platoon.SetTitleAndConnect("2Т-15");
                platoon.SetTitleAndConnect("4Т-16");
                platoon.SetTitleAndConnect("1Т-18");
            }

            platoon = platoonFactory.GetPlatoon("Артиллеристы");
            if (platoon != null)
                platoon.SetTitleAndConnect("3М-08");

            platoon = platoonFactory.GetPlatoon("Связисты");
            if (platoon != null)
                platoon.SetTitleAndConnect("2С-12");

            platoon = platoonFactory.GetPlatoon("Медицинский");
            if (platoon != null)
            {
                platoon.SetTitleAndConnect("5М-17");
                platoon.SetTitleAndConnect("5М-18");
            }

            Console.ReadKey();
        }
        /// <summary>
        /// Фасад
        /// </summary>
        public static void GoFacadePrepareSq()
        {
            Sq sq = new Sq();
            Colonel colonel = new Colonel("Пикалов А.В", "Командир роты");
            Console.WriteLine("{0} {1} {2} Снаряжает свое подразделение:", colonel.post, colonel.rank, colonel.name);
            colonel.ToManage(sq);
            Console.ReadKey();
        }
        /// <summary>
        /// Information Expert
        /// </summary>
        public static void GoInformationExpertGetSolderCount()
        {
            Sq sq = new Sq();
            Colonel colonel = new Colonel("Пикалов А.В", "Командир роты");
            Console.WriteLine("{0} {1} {2} Снаряжает свое подразделение:", colonel.post, colonel.rank, colonel.name);
            Print(colonel.ToManage(sq));
            Console.WriteLine();
            colonel.GetSqSolderCount(sq);
            Console.ReadKey();
        }

        static void Print(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        static void Print(string line)
        {
            Console.WriteLine(line);
        }

        static void Print(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
