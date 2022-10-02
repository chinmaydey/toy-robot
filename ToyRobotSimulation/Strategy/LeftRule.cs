using ToyRobotSimulation.GameEntities.Placement;

namespace ToyRobotSimulation.Strategy
{
    public class LeftRule : BaseRule
    {
        protected override string Rule { get; set; } = "^(Left)$";

        public override void Execute(string commandlineText, ref IPlacement placement)
        {
            base.Execute(commandlineText, ref placement);
            placement.Left();
        }
    }
}
