using System;

namespace KataSpaceTest
{
    internal class Robot
    {
        public Coordinate Coordinate { get; private set; }

        protected Robot(Coordinate coordinate)
        {
            this.Coordinate = coordinate;
        }


        public static Robot Of(Coordinate coordinate)
        {
            if ("Est".Equals(coordinate.Direction))
            {
               
            }
            return new Robot(coordinate);
        }

        public void MoveForward()
        {
            int columnModified = Coordinate.Column;
            switch (Coordinate.Direction)
            {
                case "West":
                    columnModified--;
                    break;
                case "Est":
                    columnModified++;
                    break;
            }
            Coordinate.ChangeCoordinateLineAndCoordinate(Coordinate.Line, columnModified);
           
        }
    }
}