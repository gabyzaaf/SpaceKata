namespace KataSpaceTest
{
    internal class RobotEst : Robot
    {
        

        public RobotEst(Coordinate coordinate) : base(coordinate)
        {
            
        }

        public override void MoveForward()
        {
            int columnModified = Coordinate.Column;
            columnModified++;
            Coordinate.ChangeCoordinateLineAndCoordinate(Coordinate.Line, columnModified);
        }
    }
}