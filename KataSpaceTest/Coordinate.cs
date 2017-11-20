namespace KataSpaceTest
{
    internal class Coordinate
    {
        public int Line { get; private set; }
        public int Column { get; private set; }
        public string Direction { get; private set; }

        public Coordinate(int line, int column, string direction)
        {
            this.Line = line;
            this.Column = column;
            this.Direction = direction;
        }

        public void ChangeCoordinateLineAndCoordinate(int line,int column)
        {
            this.Line = line;
            this.Column = column;
        }
    }
}