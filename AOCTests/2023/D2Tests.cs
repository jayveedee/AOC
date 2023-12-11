using AOC;
using NUnit.Framework;
using src._2023;

namespace test_2023
{
    internal class D2Tests : TestUtils, IAOCTests
    {
        [Test]
        public void PartOneActual()
        {
            // Arrange
            var unit = new D2();

            // Act
            var actual = unit.P1(InputHandler.GetInput(2, 1));

            // Assert
            Assert.AreEqual(8, actual);
        }

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new D2();

            // Act
            var actual = unit.P1(InputHandler.GetInput(2, 1, true));

            // Assert
            Assert.AreEqual(8, actual);
        }

        [Test]
        public void PartTwoActual()
        {
            // Arrange
            var unit = new D2();

            // Act
            var actual = unit.P2(InputHandler.GetInput(2, 2));

            // Assert
            Assert.AreEqual(70924, actual);
        }

        [Test]
        public void PartTwoExample()
        {
            // Arrange
            var unit = new D2();

            // Act
            var actual = unit.P2(InputHandler.GetInput(2, 2, true));

            // Assert
            Assert.AreEqual(2286, actual);
        }
    }
}
