using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IRobotPlan
    {
        public string Head { get; set; }
        public string Body { get; set; }
    }
}
