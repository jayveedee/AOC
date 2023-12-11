using AOC;
using NUnit.Framework;
using src._2023;
using System;

namespace test_2023
{
    internal class D1Tests : TestUtils, IAOCTests
    {
        [Test]
        public void PartOneActual()
        {
            // Arrange
            var unit = new D1();

            // Act
            var actual = unit.P1(InputHandler.GetInput(1, PartOne));

            // Assert
            Console.WriteLine(actual);
            Assert.AreEqual(53651, actual);
        }

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new D1();

            // Act
            var actual = unit.P1(InputHandler.GetInput(1, PartOne, true));

            // Assert
            Assert.AreEqual(142, actual);
        }

        [Test]
        public void PartTwoActual()
        {
            // Arrange
            var unit = new D1();

            // Act
            var actual = unit.P2(InputHandler.GetInput(1, PartTwo));

            // Assert
            Assert.AreEqual(281, actual);
        }

        [Test]
        public void PartTwoExample()
        {
            // Arrange
            var unit = new D1();

            // Act
            var actual = unit.P2(InputHandler.GetInput(1, PartTwo, true));

            // Assert
            Assert.AreEqual(281, actual);
        }
    }
}
