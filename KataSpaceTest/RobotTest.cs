using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataSpaceTest
{
    
    public class RobotTest
    {
        private Robot robot;
        private LinkedList<Robot> robotMapList;
        private RobotMap robotMap;
        private Robot robotWest;

        [SetUp]
        public void Init()
        {
            this.robot = Robot.Of(new Coordinate(0, 1, "Est"));
            robotWest = Robot.Of(new Coordinate(0, 3, "West"));
            robotMapList = new LinkedList<Robot>();
            robotMapList.AddFirst(this.robot);
            robotMapList.AddFirst(robotWest);
            robotMap = new RobotMap(robotMapList);
        }

        [Test]
        public void Should_Create_A_Robot_And_Validate_Line()
        {
            
            Check.That(robot.Coordinate.Line).IsEqualTo(0);
        }

        [Test]
        public void Should_Create_A_Robot_And_Validate_Column()
        {
            
            Check.That(robot.Coordinate.Column).IsEqualTo(1);
        }

        [Test]
        public void Should_Create_A_Robot_And_Validate_Direction()
        {
            
            Check.That(robot.Coordinate.Direction).IsEqualTo("Est");
        }

        [Test]
        public void Should_Create_A_Map_And_Validate_Robot()
        {
           
            Check.That(robotMap.IsPresent(0, 1)).IsTrue();
        }

        [Test]
        public void Should_Obtain_A_Robot_To_Specific_Coordonate()
        {
            Robot robotExpected = robotMap.ObtainRobotToCoordonate(0,1);
            Check.That(robotExpected).IsEqualTo(this.robot);
        }
        
        [Test]
        public void Should_moving_forward_From_West()
        {
            robotWest.MoveForward();
            Check.That(robotWest.Coordinate.Line).IsEqualTo(0);
            Check.That(robotWest.Coordinate.Column).IsEqualTo(2);
            
        }

        
        [Test]
        public void Should_moving_forward_From_Est()
        {
            robot.MoveForward();
            Check.That(robot.Coordinate.Line).IsEqualTo(0);
            Check.That(robot.Coordinate.Column).IsEqualTo(2);
           
        }


        /*
        [Test]
        public void Should_Refacto_Coordinate()
        {
            Robot robotEst = Robot.Of(new Coordinate(0, 1, "Est"));
            Robot robotWests = Robot.Of(new Coordinate(1, 1, "West"));
            var robotList = new LinkedList<Robot>();
            robotList.AddFirst(robotEst);
            robotList.AddFirst(robotWests);

            var robotMap = new RobotMap(robotList);
            var robotExpected = robotMap.MoveForward(0, 1);
            Check.That(robotExpected.Coordinate.Column).IsEqualTo(2);

        }
        */
    }
}
