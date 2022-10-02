using ToyRobotSimulation.GameEntities.Placement;

namespace ToyRobotSimulation.Strategy
{
    public class MoveRule : BaseRule
    {
        protected override string Rule { get; set; } = "^(Move)$";

        public override void Execute(string commandlineText, ref IPlacement placement)
        {
            base.Execute(commandlineText, ref placement);
            placement.Move();
        }
    }
}
