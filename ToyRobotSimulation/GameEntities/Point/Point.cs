namespace ToyRobotSimulation.GameEntities.Point
{
    /// <summary>
    /// Point class implementation of the 2D point
    /// </summary>
    public class Point : IPoint
    {
        private readonly int MAX_X = 5, MAX_Y = 5;
        private int _x, _y;

        public Point(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new InvalidDataException($"Point (x,y) must be positive integer {x},{y}");
            else if (x >= MAX_X || y >= MAX_Y)
                throw new InvalidDataException($"Point (x,y) max limit x={MAX_X - 1},y={MAX_Y - 1}");

            _x = x;
            _y = y;
        }

        public void MoveLeft()
        {
            if (_x - 1 >= 0)
                _x--;
        }

        public void MoveRight()
        {
            if (_x + 1 < MAX_X)
                _x++;
        }

        public void MoveDown()
        {
            if (_y - 1 >= 0)
                _y--;
        }

        public void MoveUp()
        {
            if (_y + 1 < MAX_Y)
                _y++;
        }

        public override string ToString()
        {
            return $"{_x},{_y}";
        }
    }
}
