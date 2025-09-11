using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2Task
{
    internal class TIME
    {
         public double hours { get; set; }
         public double minutes { get; set; }
          public double seconds { get; set; }
         public override string ToString()
        {
            return $"{hours}H:{minutes}M:{seconds}S";
        }
    }
}
