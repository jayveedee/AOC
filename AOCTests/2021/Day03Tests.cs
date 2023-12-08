using System;
using AOC;
using AOC._2021;
using NUnit.Framework;

namespace test._2021
{
    public class Day03Tests : Extension, IAOCTests
    {
        private const int Day = 3;

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day03();

            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, true));

            // Assert
            Assert.AreEqual(198, actual);

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
            var unit = new Day03();

            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, true));

            // Assert
            Assert.AreEqual(230, actual);

        }

        [Test]
        public void PartTwoActual()
        {
            // Arrange
            var unit = new Day03();

            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, false));

            // Assert
            Console.WriteLine(actual);
            Assert.AreEqual(2845944, actual);

        }
    }
}