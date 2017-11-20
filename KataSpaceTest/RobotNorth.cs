namespace KataSpaceTest
{
    internal class RobotNorth : Robot
    {
        public RobotNorth(Coordinate coordinate) : base(coordinate)
        {
        }

        public override void MoveForward()
        {
            int lineModified = Coordinate.Line;
            lineModified--;
            Coordinate.ChangeCoordinateLineAndCoordinate(lineModified, Coordinate.Column);
        }
    }
}