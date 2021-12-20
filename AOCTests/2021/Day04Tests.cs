using System;
using AOC;
using AOC._2021;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    public class Day04Tests : Extension, IAOCTests
    {
        private const int Day = 4, PartOne = 1, PartTwo = 2;

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day04();

            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, true));

            // Assert
            Assert.AreEqual(4512, actual);

        }

        [Test]
        public void PartOneActual()
        {
            // Arrange
            
            // Act
            
            // Assert

        }

        [Test]
        public void PartTwoExample()
        {
            // Arrange
            var unit = new Day04();

            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, true));

            // Assert
            Assert.AreEqual(1924, actual);

        }

        [Test]
        public void PartTwoActual()
        {
            // Arrange
            var unit = new Day04();
            
            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, false));
            
            // Assert
            Console.WriteLine(actual);
            Assert.AreEqual(1284, actual);

        }
    }
}