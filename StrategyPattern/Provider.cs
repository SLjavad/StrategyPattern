using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Provider
    {
        public int ProviderId { get; set; }
        public string Name { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}
