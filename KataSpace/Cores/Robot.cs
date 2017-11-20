using System;

namespace KataSpaceTest
{
    public class Robot
    {
        public Coordinate Coordinate { get; private set; }

        protected Robot(Coordinate coordinate)
        {
            this.Coordinate = coordinate;
        }


        public static Robot Of(Coordinate coordinate)
        {
            switch (coordinate.Direction)
            {
                case "Est" :
                    return new RobotEst(coordinate);
                case "West":
                    return new RobotWest(coordinate);
                case "North":
                    return new RobotNorth(coordinate);
                case "South":
                    return new RobotSouth(coordinate);
            }
            return null;
        }

        public virtual void MoveForward()
        {
            
           
        }
    }
}