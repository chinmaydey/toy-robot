namespace ToyRobotSimulation.GameEntities.Placement
{
    /// <summary>
    /// Interface to define a specific position on board
    /// </summary>
    public interface IPlacement
    {
        public void Move();
        public void Left();
        public void Right();
    }
}
