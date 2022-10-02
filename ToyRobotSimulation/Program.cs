using ToyRobotSimulation.GameEntities.Placement;
using ToyRobotSimulation.Strategy;

class RobotSimulation
{
    static public void Main(string[] args)
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

        // assuming the filename argument exist
        if (args.Length > 0 && File.Exists(args[0]))
        {
            Console.WriteLine($"Running file mode with filename={args[0]}");

            IEnumerable<string> commandLines = File.ReadLines(args[0]);

            foreach (var command in commandLines)
            {
                try
                {
                    Console.WriteLine(command);
                    ruleEngine.Execute(command, ref placement);
                }
                catch (Exception ex)
                {
                    Console.Write($"Error: {ex.Message}");
                }
            }
        }
        else
        {
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
                catch (Exception ex)
                {
                    Console.Write($"Error: {ex.Message}");
                }
            }
        }
    }
}