using System;
using AOC;
using AOC._2021;
using AOC.InputService;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    public class Day07Tests : Extension, IAOCTests
    {
        private const int Day = 7, PartOne = 1, PartTwo = 2;

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day07();
            
            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, true));
            
            // Assert
            Assert.AreEqual(37, actual);
            
        }

        [Test]
        public void PartOneActual()
        {
            // Arrange
            var unit = new Day07();
            
            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, false));
            
            // Assert
            Console.WriteLine(actual);
        }

        [Test]
        public void PartTwoExample()
        {
            // Arrange
            var unit = new Day07();
            
            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, true));
            
            // Assert
            Assert.AreEqual(168, actual);
        }

        [Test]
        public void PartTwoActual()
        {
            // Arrange
            var unit = new Day07();
            
            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, false));
            
            // Assert
            Console.WriteLine(actual);
            Assert.AreEqual(96708205, actual);
            
        }
    }
}