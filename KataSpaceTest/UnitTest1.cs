using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NUnit.Framework;

namespace KataSpaceTest
{
    
    public class SpaceAcceptanceTest
    {
        [Test]
        public void Should_Move_Right()
        {
            Robot robotEst = Robot.Of(new Coordinate(0,1,"Est"));
            Robot robotWest = Robot.Of(new Coordinate(1, 1, "West"));
            var robotList = new LinkedList<Robot>();
            robotList.AddFirst(robotEst);
            robotList.AddFirst(robotWest);

            var robotMap = new RobotMap(robotList);
            robotEst.MoveForward();
            Check.That(robotEst.Coordinate.Column).IsEqualTo(2);

        }
    }
}
