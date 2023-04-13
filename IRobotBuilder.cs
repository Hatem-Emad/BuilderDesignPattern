using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface IRobotBuilder
    {
        public void BuildHead();
        public void BuildBody();
        public Robot GetRobot();
    }
}
