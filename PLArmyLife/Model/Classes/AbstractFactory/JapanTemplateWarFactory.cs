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
    class JapanTemplateWarFactory : IWarFactory
    {
        private IPlan plan;
        public IPlan GetPlan()
        {
            if (plan == null)
            {
                plan = new PlanA();
            }
            return plan;
        }

        public ICondition GetCondition()
        {
            return new BadConditions(GetPlan());
        }
    }
}
