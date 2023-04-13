using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class RobotEngineer
    {
        private IRobotBuilder robotBuilder;
        public RobotEngineer(IRobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }
        public Robot GetRobot() => robotBuilder.GetRobot();
        public void MakeRobot()
        {
            robotBuilder.BuildHead();
            robotBuilder.BuildBody();
        }
    }
}
