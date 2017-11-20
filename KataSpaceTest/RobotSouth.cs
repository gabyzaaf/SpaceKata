namespace KataSpaceTest
{
    internal class RobotSouth : Robot
    {
        public RobotSouth(Coordinate coordinate) : base(coordinate)
        {
        }

        public override void MoveForward()
        {
            int lineModified = Coordinate.Line;
            lineModified++;
            Coordinate.ChangeCoordinateLineAndCoordinate(lineModified, Coordinate.Column);
        }
    }
}