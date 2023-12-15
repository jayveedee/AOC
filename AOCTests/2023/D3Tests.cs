using AOC;
using NUnit.Framework;
using src._2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_2023;

namespace AOC2021Tests._2023
{
    internal class D3Tests : TestUtils, IAOCTests
    {
        [Test]
        public void PartOneActual()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void PartOneExample()
        {
            // Arrange
            var unit = new D3();

            // Act
            var actual = unit.P1(InputHandler.GetInput(3, 1, true));

            // Assert
            Assert.AreEqual(4361, actual);
        }

        [Test]
        public void PartTwoActual()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void PartTwoExample()
        {
            throw new NotImplementedException();
        }
    }
}
