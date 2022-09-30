using ToyRobotSimulation.GameEntities.Placement;
using ToyRobotSimulation.GameEntities.Point;

namespace ToyRobotSimulation.Test
{
    public class GameEntitiesTests
    {
        [Theory]
        [InlineData("North", 0, 0, "0,1,NORTH")]
        [InlineData("South", 0, 0, "0,0,SOUTH")]
        [InlineData("East", 0, 0, "0,0,EAST")]
        [InlineData("West", 0, 0, "1,0,WEST")]
        public void Placement_Move_Left_Right_Valid(string direction, int x, int y, string expectedOutput)
        {
            var placement = new Placement(direction, new Point(x, y));
            placement.Move();
            placement.Left();
            placement.Right();

            Assert.Equal(expectedOutput, placement.ToString());
        }


        [Theory]
        [InlineData("InvalidDirection", 0, 0)]
        [InlineData(null, 0, 0)]
        public void Placement_InvalidDirection_ThrowsException(string invalidDirection, int x, int y)
        {
            var exception = Assert.Throws<InvalidDataException>(() => new Placement(invalidDirection, new Point(x, y)));

            Assert.Equal($"Invalid direction string {invalidDirection}", exception.Message);
        }

        [Theory]
        [InlineData("North", -1, 0)]
        [InlineData("North", 0, -1)]
        [InlineData("North", -1, -1)]
        public void Placement_InvalidPoint_ThrowsException(string direction, int x, int y)
        {
            var exception = Assert.Throws<InvalidDataException>(() => new Placement(direction, new Point(x, y)));

            Assert.Equal($"Point (x,y) must be positive integer {x},{y}", exception.Message);
        }
    }
}