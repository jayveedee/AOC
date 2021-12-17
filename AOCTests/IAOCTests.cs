using NUnit.Framework;

namespace AOC
{
    public interface IAOCTests
    {
        [Test]
        public void PartOneExample();

        [Test]
        public void PartOneActual();

        [Test]
        public void PartTwoExample();

        [Test]
        public void PartTwoActual();
    }
}