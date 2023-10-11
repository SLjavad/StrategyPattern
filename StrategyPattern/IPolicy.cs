using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IPolicy
    {
        ICondition? Condition { get; set; }
        List<Hotel> Exec(List<Provider> providers);
    }
}
