using System;
using AOC;
using AOC._2021;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    public class Day21Tests : Extension, IAOCTests
    {
        private int Day = 21;

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day21();

            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, true));

            // Assert
            Assert.AreEqual(739785, actual);

        }

        [Test]
        public void PartOneActual()
        {
            // Arrange
            var unit = new Day21();

            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, false));

            // Assert
            Console.WriteLine(actual);
            Assert.AreEqual(921585, actual);
        }

        [Test]
        public void PartTwoExample()
        {
            // Arrange
            var unit = new Day21();

            // Act
            var actual = unit.PartTwo(InputHandler.GetInput(Day, PartTwo, true));

            // Act
            Assert.AreEqual(444356092776315, actual);
        }

        [Test]
        public void PartTwoActual()
        {
            throw new System.NotImplementedException();
        }
    }
}