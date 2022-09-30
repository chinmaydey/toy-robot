using ToyRobotSimulation.GameEntities.Point;

namespace ToyRobotSimulation.GameEntities.Placement
{
    public enum CardinalDirection
    {
        NORTH = 0,
        WEST = 90,
        SOUTH = 180,
        EAST = 270
    }

    public class Placement : IPlacement
    {
        private CardinalDirection _direction;
        private readonly IPoint _point;

        public Placement(string direction, IPoint point)
        {
            _point = point;

            if (!Enum.TryParse(typeof(CardinalDirection), direction, true, out var lDirection))
            {
                throw new InvalidDataException($"Invalid direction string {direction}");
            }

            _direction = (CardinalDirection)lDirection;
        }

        public void Move()
        {
            switch (_direction)
            {
                case CardinalDirection.NORTH:
                    _point.MoveUp();
                    break;
                case CardinalDirection.SOUTH:
                    _point.MoveDown();
                    break;
                case CardinalDirection.EAST:
                    _point.MoveLeft();
                    break;
                case CardinalDirection.WEST:
                    _point.MoveRight();
                    break;
            }
        }

        public void Left() => _direction = (CardinalDirection)((int)(_direction + 90) % 360);

        public void Right() => _direction = (CardinalDirection)(((_direction == CardinalDirection.NORTH ? 360 : (int)_direction) - 90) % 360);

        public override string ToString() => $"{_point},{_direction}";
    }
}
