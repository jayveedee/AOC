using System;
using AOC;
using AOC._2021;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    public class Day20Tests : Extension, IAOCTests
    {
        private readonly int Day = 20;

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day20();

            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, true));

            // Assert
            Assert.AreEqual(35, actual);

        }

        [Test]
        public void PartOneActual()
        {
            // Arrange
            var unit = new Day20();

            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, false));

            // Assert
            Console.WriteLine(actual);
        }

        [Test]
        public void PartTwoExample()
        {
            throw new System.NotImplementedException();
        }

        [Test]
        public void PartTwoActual()
        {
            throw new System.NotImplementedException();
        }
    }
}