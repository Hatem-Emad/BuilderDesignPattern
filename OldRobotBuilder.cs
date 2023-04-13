namespace Builder
{
    public class OldRobotBuilder : IRobotBuilder
    {
        private Robot robot;
        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }
        public void BuildHead()
        {
            robot.Head = "Tin Head";
        }
        public void BuildBody()
        {
            robot.Body = "Tin Body";
        }
        public Robot GetRobot() => this.robot;

    }
}
