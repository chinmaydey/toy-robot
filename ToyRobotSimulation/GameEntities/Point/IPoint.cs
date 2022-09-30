namespace ToyRobotSimulation.GameEntities.Point
{
    /// <summary>
    /// Interface to represent 2D point
    /// </summary>
    public interface IPoint
    {
        public void MoveLeft();
        public void MoveRight();
        public void MoveUp();
        public void MoveDown();
    }
}
