using System;
using AOC;
using AOC._2021;
using AOC.InputService;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    public class Day06Tests : IAOCTests
    {
        private const int Day = 6, PartOne = 1, PartTwo = 2;
        private readonly IInputHandler _inputHandler = new InputHandler();
        
        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day06();

            // Act
            var actual1 = unit.PartOneTwo(_inputHandler.GetInput(Day, PartOne, true), 18);
            var actual2 = unit.PartOneTwo(_inputHandler.GetInput(Day, PartOne, true), 80);

            // Assert
            Assert.AreEqual(26, actual1);
            Assert.AreEqual(5934, actual2);

        }

        [Test]
        public void PartOneActual()
        {
            // Arrange
            var unit = new Day06();
            
            // Act
            var actual = unit.PartOneTwo(_inputHandler.GetInput(Day, PartOne, false), 80);

            // Assert
            Console.WriteLine(actual);

        }

        [Test]
        public void PartTwoExample()
        {
            // Arrange
            var unit = new Day06();
            
            // Act
            var actual = unit.PartOneTwo(_inputHandler.GetInput(Day, PartTwo, true), 256);
            
            // Assert
            Assert.AreEqual(26984457539, actual);
        }

        [Test]
        public void PartTwoActual()
        {
            // Arrange
            var unit = new Day06();
            
            // Act
            var actual = unit.PartOneTwo(_inputHandler.GetInput(Day, PartTwo, false), 256);
            
            // Assert
            Console.WriteLine(actual);
            Assert.AreEqual(1590327954513, actual);
            
        }
    }
}