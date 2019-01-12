using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmyLife.Model.Interfaces.Bridge;

namespace PLArmyLife.Model.Interfaces.AbstractFactory
{
    interface IWarFactory
    {
        IPlan GetPlan();
        ICondition GetCondition();
    }
}
