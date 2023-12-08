using System;
using AOC;
using AOC._2021;
using NUnit.Framework;

namespace test._2021
{
    public class Day08Tests : Extension, IAOCTests
    {
        private const int Day = 8;

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day08();

            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, true));

            // Assert
            Assert.AreEqual(26, actual);

        }

        [Test]
        public void PartOneActual()
        {
            // Arrange
            var unit = new Day08();
            
            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, false));
            
            // Assert
            Console.WriteLine(actual);
        }

        [Test]
        public void PartTwoExample()
        {
            // Arrange
            var unit = new Day08();

            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, true));

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