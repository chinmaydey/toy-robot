using ToyRobotSimulation.GameEntities.Placement;

namespace ToyRobotSimulation.Strategy
{
    public class ExitRule : BaseRule
    {
        protected override string Rule { get; set; } = "^(Exit)$";

        public override void Execute(string commandlineText, ref IPlacement placement)
        {
            Console.WriteLine("Exiting the game");
            Environment.Exit(0);
        }
    }
}
