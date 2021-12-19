using System;
using AOC;
using AOC._2021;
using AOC.InputService;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    public class Day08Tests : IAOCTests
    {
        private const int Day = 8, PartOne = 1, PartTwo = 2;
        private readonly IInputHandler _inputHandler = new InputHandler();
        
        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day08();

            // Act
            var actual = unit.PartOne(_inputHandler.GetInput(Day, PartOne, true));

            // Assert
            Assert.AreEqual(26, actual);

        }

        [Test]
        public void PartOneActual()
        {
            // Arrange
            var unit = new Day08();
            
            // Act
            var actual = unit.PartOne(_inputHandler.GetInput(Day, PartOne, false));
            
            // Assert
            Console.WriteLine(actual);
        }

        [Test]
        public void PartTwoExample()
        {
            // Arrange
            var unit = new Day08();

            // Act
            var actual = unit.PartTwo(_inputHandler.GetInput(Day, PartTwo, true));

            // Assert
            Assert.AreEqual(5353, actual);

        }

        [Test]
        public void PartTwoActual()
        {
            throw new System.NotImplementedException();
        }
    }
}