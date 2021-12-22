using AOC;
using AOC._2021;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    public class Day22Tests : Extension, IAOCTests
    {
        private readonly int Day = 22;

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day22();

            // Act
            var actual = unit.PartOne(InputHandler.GetInput(Day, PartOne, true));

            // Assert
            Assert.AreEqual(39, actual);
        }

        [Test]
        public void PartOneActual()
        {
            throw new System.NotImplementedException();
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