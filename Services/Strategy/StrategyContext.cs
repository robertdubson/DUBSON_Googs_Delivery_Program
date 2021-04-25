using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Strategy
{
    public class StrategyContext
    {
        public IStrategy CurrentStrategy { get; set; }

        public StrategyContext(IStrategy currentStrategy) {

            CurrentStrategy = currentStrategy;
        
        }
    }
}
