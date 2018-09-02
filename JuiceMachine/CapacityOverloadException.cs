using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceMachine
{
    class CapacityOverloadException: Exception
    {
        

        public CapacityOverloadException(): base("Max capacity of the Juicer has been reached")
        {
            
        }
    }
}
