using ToyRobotSimulation.GameEntities.Placement;
using ToyRobotSimulation.GameEntities.Point;
using ToyRobotSimulation.Strategy;

namespace ToyRobotSimulation.Test
{
    public class StrategyTests
    {
        [Theory]
        [InlineData("Place 1,1,North","1,1,NORTH")]
        [InlineData("PLACE 3,4,West", "3,4,WEST")]
        public void PlaceRule_Expecting_ValidResult(string commandText, string expectedOutput)
        {
            IPlacement placement = null;
            var placeRule = new PlaceRule();

            var validCommand = placeRule.Verify(commandText);            
            placeRule.Execute(commandText, ref placement);

            Assert.True(validCommand);
            Assert.Equal(expectedOutput, placement.ToString());
        }

        [Theory]
        [InlineData("Place 1,1,N")]
        [InlineData("PLACE 3,West")]
        public void PlaceRule_Expecting_InvalidResult(string commandText)
        {
            IPlacement placement = null;
            var placeRule = new PlaceRule();

            var validCommand = placeRule.Verify(commandText);
            placeRule.Execute(commandText, ref placement);

            Assert.False(validCommand);
            Assert.Null(placement);
        }

        [Fact]        
        public void LeftRule_Validate_LeftRotation()
        {
            IPlacement placement = null;
            var commandText = "Place 0,0,North";
            var placeRule = new PlaceRule();

            placeRule.Execute(commandText, ref placement);
            placement.Left();
            placement.Left();
            placement.Left();
            placement.Left();

            Assert.Equal("0,0,NORTH", placement.ToString());
        }

        [Fact]
        public void RightRule_Validate_RightRotation()
        {
            IPlacement placement = null;
            var commandText = "Place 0,0,North";
            var placeRule = new PlaceRule();

            placeRule.Execute(commandText, ref placement);
            placement.Right();
            placement.Right();
            placement.Right();
            placement.Right();

            Assert.Equal("0,0,NORTH", placement.ToString());
        }

        [Fact]
        public void MoveRule_Validate_Movement()
        {
            IPlacement placement = null;
            var commandText = "Place 0,0,North";
            var placeRule = new PlaceRule();

            placeRule.Execute(commandText, ref placement);            
            placement.Move();
            placement.Move();
            placement.Move();

            Assert.Equal("0,3,NORTH", placement.ToString());
        }

        [Fact]        
        public void Command_Without_Placement_ThrowsException()
        {
            IPlacement placement = null;
            var moveRule = new MoveRule();

            var exception = Assert.Throws<InvalidOperationException>(() => moveRule.Execute("Move", ref placement));

            Assert.Equal($"'Place' should be the first command", exception.Message);
        }
    }
}