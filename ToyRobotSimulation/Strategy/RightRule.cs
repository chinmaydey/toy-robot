using ToyRobotSimulation.GameEntities.Placement;

namespace ToyRobotSimulation.Strategy
{
    public class RightRule : BaseRule
    {
        protected override string Rule { get; set; } = "^(Right)$";

        public override void Execute(string commandlineText, ref IPlacement placement)
        {
            base.Execute(commandlineText, ref placement);
            placement.Right();
        }
    }
}
