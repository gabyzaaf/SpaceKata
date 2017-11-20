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

        [Test]
        public void Should_Move_North()
        {
            Robot robotNorth = Robot.Of(new Coordinate(1,1,"North"));
            Robot robotWest = Robot.Of(new Coordinate(1, 2, "West"));
            var robotList = new LinkedList<Robot>();
            robotList.AddFirst(robotNorth);
            robotList.AddFirst(robotWest);

            var robotMap = new RobotMap(robotList);
            robotNorth.MoveForward();
            Check.That(robotNorth.Coordinate.Line).IsEqualTo(0);  
        }

        [Test]
        public void Should_Move_South()
        {
            Robot robotSouth = Robot.Of(new Coordinate(1, 1, "South"));
            Robot robotWest = Robot.Of(new Coordinate(1, 2, "West"));
            var robotList = new LinkedList<Robot>();
            robotList.AddFirst(robotSouth);
            robotList.AddFirst(robotWest);

            var robotMap = new RobotMap(robotList);
            robotSouth.MoveForward();
            Check.That(robotSouth.Coordinate.Line).IsEqualTo(2);
        }
    }
}
