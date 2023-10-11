using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MergePolicy : IPolicy
    {
        public ICondition? Condition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Hotel> Exec(List<Provider> providers)
        {
            throw new NotImplementedException();
        }
    }
}
