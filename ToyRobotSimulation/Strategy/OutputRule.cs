using ToyRobotSimulation.GameEntities.Placement;

namespace ToyRobotSimulation.Strategy
{
    public class OutputRule : BaseRule
    {
        protected override string Rule { get; set; } = "^(Report)$";

        public override void Execute(string commandlineText, ref IPlacement placement)
        {
            Console.WriteLine($"Output: {placement}");
        }
    }
}
