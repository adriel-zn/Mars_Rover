using Mars_Rover.Business;
using System;
using Xunit;

namespace Mars_Rover.Test
{
    public class RoverTest
    {
        [Fact]
        public void SpinLeft()
        {
            #region Test Case 1: Input {1 2 N} to Spin Left => Return Direction {W}
            //Arrange
            Rover _rover = new Rover("1 2 N");

            //Act
            _rover.SpinLeft();

            //Assert
            Assert.Equal("W", _rover.Direction);
            #endregion

            #region Test Case 2: Input {1 2 E} to Spin Left => Return Direction {N}
            //Arrange
            _rover = new Rover("1 2 E");

            //Act
            _rover.SpinLeft();

            //Assert
            Assert.Equal("N", _rover.Direction);
            #endregion

            #region Test Case 3: Input {1 2 S} to Spin Left => Return Direction {E}
            //Arrange
            _rover = new Rover("1 2 S");

            //Act
            _rover.SpinLeft();

            //Assert
            Assert.Equal("E", _rover.Direction);
            #endregion

            #region Test Case 4: Input {1 2 W} to Spin Left => Return Direction {S}
            //Arrange
            _rover = new Rover("1 2 W");

            //Act
            _rover.SpinLeft();

            //Assert
            Assert.Equal("S", _rover.Direction);
            #endregion
        }

        [Fact]
        public void SpinRight()
        {
            //Arrange
            Rover _rover = new Rover("1 2 N");

            //Act
            _rover.SpinRight();


            //Assert
            Assert.Equal("E", _rover.Direction);
        }

        [Fact]
        public void MoveForward()
        {
            //Arrange
            Rover _rover = new Rover("1 2 N");

            //Act
            _rover.MoveForward();


            //Assert
            Assert.Equal(3, _rover.y);
        }


        [Fact]
        public void DestinationPoint()
        {
            //Arrange
            Rover _rover = new Rover("1 2 N");

            //Act
            _rover.GoToLocation("LMLMLMLMM");


            //Assert
            Assert.Equal("1 3 N", _rover.x + " " + _rover.y + " " + _rover.Direction);
        }
    }
}
