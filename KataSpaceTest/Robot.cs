using System;

namespace KataSpaceTest
{
    internal class Robot
    {
        public Coordinate Coordinate { get; private set; }

        private Robot(Coordinate coordinate)
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
    }
}