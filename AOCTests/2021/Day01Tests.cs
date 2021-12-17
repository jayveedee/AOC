using System;
using AOC;
using AOC._2021;
using AOC.InputService;
using NUnit.Framework;

namespace AOC2021Tests._2021
{
    
    public class Day01Tests : IAOCTests
    {
        private const int Day = 1, PartOne = 1, PartTwo = 2;
        private readonly IInputHandler _inputHandler = new InputHandler();
        
        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new Day01();

            // Act
            var actual = unit.PartOne(_inputHandler.GetInput(Day, PartOne, true));

            // Assert
            Assert.AreEqual(1597, actual);
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
            var unit = new Day01();

            // Act
            var actual = unit.PartTwo(_inputHandler.GetInput(Day, PartTwo, true));

            // Assert
            Assert.AreEqual(5, actual);
        }
        
        [Test]
        public void PartTwoActual()
        {
            // Arrange
            var unit = new Day01();
            
            // Act
            var actual = unit.PartTwo(_inputHandler.GetInput(Day, PartTwo, false));
            
            // Assert
            Console.WriteLine(actual);
            Assert.AreEqual(1600, actual);
        }
    }
}