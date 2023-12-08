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
            //Assert.AreEqual(142, actual);
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
            throw new System.NotImplementedException();
        }

        [Test]
        public void PartTwoExample()
        {
            throw new System.NotImplementedException();
        }
    }
}
