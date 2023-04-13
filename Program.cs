namespace Builder
{
    internal class Program
    {
        //to build objects with complex parts
        static void Main(string[] args)
        {
            IRobotBuilder robotBuilder_Old = new OldRobotBuilder();
            IRobotBuilder robotBuilder_Plastic = new PlasticRobotBuilder();
            
            RobotEngineer engineer_1 = new RobotEngineer(robotBuilder_Old);
            RobotEngineer engineer_2 = new RobotEngineer(robotBuilder_Plastic);
            
            engineer_1.MakeRobot();
            engineer_2.MakeRobot();
            
            Robot Robot_11 = engineer_1.GetRobot();
            Robot Robot_12 = engineer_1.GetRobot();

            Robot Robot_21 = engineer_2.GetRobot();
            Robot Robot_22 = engineer_2.GetRobot();
            
            Console.WriteLine($"First Robot_11 built with: {Robot_11.Head} and {Robot_11.Body}");
            Console.WriteLine($"First Robot_12 built with: {Robot_12.Head} and {Robot_12.Body}");
            Console.WriteLine($"First Robot_21 built with: {Robot_21.Head} and {Robot_21.Body}");
            Console.WriteLine($"First Robot_22 built with: {Robot_22.Head} and {Robot_22.Body}");
        }
    }
}