using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmyLife.Model.Classes.Bridge;
using PLArmyLife.Model.Interfaces.AbstractFactory;
using PLArmyLife.Model.Interfaces.Bridge;

namespace PLArmyLife.Model.Classes.AbstractFactory
{
    class FranceTemplateWarFactory : IWarFactory
    {
        private IPlan plan;
        public IPlan GetPlan()
        {
            if (plan == null)
            {
                plan = new PlanB();
            }
            return plan;
        }

        public ICondition GetCondition()
        {
            return new GoodConditions(GetPlan());
        }
    }
}
