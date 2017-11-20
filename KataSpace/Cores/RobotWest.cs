namespace KataSpaceTest
{
    internal class RobotWest : Robot
    {
        public RobotWest(Coordinate coordinate) : base(coordinate)
        {

        }

        public override void MoveForward()
        {
            int columnModified = Coordinate.Column;
            columnModified--;
            Coordinate.ChangeCoordinateLineAndCoordinate(Coordinate.Line, columnModified);
        }
    }
}