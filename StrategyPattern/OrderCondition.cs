using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class OrderCondition : ICondition
    {
        public List<int> ProviderOrders { get; set; }
    }
}
