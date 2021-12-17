using AOC;
using AOC._2021;
using AOC.InputService;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    public class Day03Tests : IAOCTests
    {
        private const int Day = 3, PartOne = 1, PartTwo = 2;
        private readonly IInputHandler _inputHandler = new InputHandler();
        
        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day03();

            // Act
            var actual = unit.PartOne(_inputHandler.GetInput(Day, PartOne, true));

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
            var actual = unit.PartTwo(_inputHandler.GetInput(Day, PartTwo, true));

            // Assert
            Assert.AreEqual(230, actual);

        }

        [Test]
        public void PartTwoActual()
        {
            // Arrange
            
            // Act
            
            // Assert

        }
    }
}