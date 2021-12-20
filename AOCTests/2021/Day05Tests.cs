using System;
using AOC;
using AOC._2021;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    public class Day05Tests : Extension, IAOCTests
    {
        private const int Day = 5;

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day05();

            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, true));

            // Assert
            Assert.AreEqual(5, actual);

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
            var unit = new Day05();

            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, true), true);

            // Assert
            Assert.AreEqual(12, actual);

        }

        [Test]
        public void PartTwoActual()
        {
            // Arrange
            var unit = new Day05();

            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, false), false);

            // Assert
            Console.WriteLine(actual);

        }
    }
}