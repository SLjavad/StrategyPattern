using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MinPricePolicy : IPolicy
    {
        public ICondition? Condition { get; set; }

        public List<Hotel> Exec(List<Provider> providers)
        {
            var hotels = providers.SelectMany(x => x.Hotels).GroupBy(x => x.Name).Select(x => x.MinBy(y => y.Price)).ToList();
            return hotels!;
        }
    }
}
