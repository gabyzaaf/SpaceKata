using System;
using System.Collections.Generic;
using System.Linq;

namespace KataSpaceTest
{
    internal class RobotMap
    {
        private LinkedList<Robot> robotMapList;

        public RobotMap(LinkedList<Robot> robotMapList)
        {
            this.robotMapList = new LinkedList<Robot>(robotMapList);
        }

        internal bool IsPresent(int line, int column)
        {
            var robotNumerInTheSameCoordonate = robotMapList.Count(r => r.Coordinate.Line == line && r.Coordinate.Column == column);
            if (robotNumerInTheSameCoordonate > 0)
            {
                return true;
            }
            return false;
        }

        

        public Robot ObtainRobotToCoordonate(int line, int column)
        {
            return this.robotMapList.Single(c => c.Coordinate.Line == line && c.Coordinate.Column == column);
        }
    }
}