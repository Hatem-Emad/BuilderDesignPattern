using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class PlasticRobotBuilder : IRobotBuilder
    {
        private Robot robot;
        public PlasticRobotBuilder()
        {
            this.robot = new Robot();
        }

        public void BuildHead()
        {
            robot.Head = "Plastic Head";
        }

        public void BuildBody()
        {
            robot.Body = "Plastic Body";
        }
        public Robot GetRobot() => this.robot;
        
    }
}
