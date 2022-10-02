using System.Text.RegularExpressions;
using ToyRobotSimulation.GameEntities.Placement;

namespace ToyRobotSimulation.Strategy
{
    public abstract class BaseRule : IRule
    {
        protected abstract string Rule { get; set; }
        
        public virtual void Execute(string commandlineText, ref IPlacement placement)
        {
            if (placement == null)
                throw new InvalidOperationException("'Place' should be the first command");
        }

        public bool Verify(string commandlineText)
        {
            return Regex.Match(commandlineText, Rule, RegexOptions.IgnoreCase).Success;
        }
    }
}
