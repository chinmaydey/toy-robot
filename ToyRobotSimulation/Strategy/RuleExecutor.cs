using ToyRobotSimulation.GameEntities.Placement;

namespace ToyRobotSimulation.Strategy
{
    public class RuleEngine
    {
        public List<IRule> Rules { get; set; }

        public void Execute(string commandlineText, ref IPlacement placement)
        {
            foreach (var rule in Rules)
            {
                if (rule.Verify(commandlineText))
                {
                    rule.Execute(commandlineText, ref placement);
                    break;
                }
            }
        }
    }
}
