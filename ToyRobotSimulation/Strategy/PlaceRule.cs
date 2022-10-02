using System.Text.RegularExpressions;
using ToyRobotSimulation.GameEntities.Placement;
using ToyRobotSimulation.GameEntities.Point;

namespace ToyRobotSimulation.Strategy
{
    public class PlaceRule : BaseRule
    {
        protected override string Rule { get; set; } = "^Place ([0-9]+),([0-9]+),(North|South|East|West)$";

        public override void Execute(string commandlineText, ref IPlacement placement)
        {
            var group = Regex.Match(commandlineText, Rule, RegexOptions.IgnoreCase);

            if(group.Success)
            {
                // assign a new placement
                placement = new Placement(group.Groups[3].ToString(), new Point(Int32.Parse(group.Groups[1].ToString()), Int32.Parse(group.Groups[2].ToString())));
            }
        }
    }
}
