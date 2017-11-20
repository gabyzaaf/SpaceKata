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
            switch (coordinate.Direction)
            {
                case "Est" :
                    return new RobotEst(coordinate);
                case "West":
                    return new RobotWest(coordinate);
            }
            return null;
        }

        public virtual void MoveForward()
        {
            
           
        }
    }
}