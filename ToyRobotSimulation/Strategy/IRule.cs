using ToyRobotSimulation.GameEntities.Placement;

namespace ToyRobotSimulation.Strategy
{
    public interface IRule
    {
        bool Verify(string commandlineText);
        void Execute(string commandlineText, ref IPlacement placement);
    }
}
