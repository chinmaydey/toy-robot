using ToyRobotSimulation.GameEntities.Placement;
using ToyRobotSimulation.Strategy;

class RobotSimulation
{
    static public void Main()
    {
        IPlacement placement = null;
        RuleEngine ruleEngine = new RuleEngine();
        ruleEngine.Rules = new List<IRule>() {
            new PlaceRule(),
            new MoveRule(),
            new LeftRule(),
            new RightRule(),
            new OutputRule(),
            new ExitRule()
        };

        Console.WriteLine("Welcome to Toy Robot Game");
        Console.WriteLine("Choose one of the following Commands...");
        Console.WriteLine("- PLACE X,Y,F (F=>NORTH,SOUTH,EAST,WEST)");
        Console.WriteLine("- MOVE");
        Console.WriteLine("- LEFT");
        Console.WriteLine("- RIGHT");
        Console.WriteLine("- REPORT");
        Console.WriteLine("- EXIT");

        while (true)
        {
            Console.Write("");
            var userInput = Console.ReadLine();
            try
            {
                ruleEngine.Execute(userInput, ref placement);
            }
            catch(Exception ex)
            {
                Console.Write($"Error: {ex.Message}");
            }
        }
    }
}