using src.utils.interfaces;
using src.utils.services;

namespace test_2023
{
    internal class TestUtils
    {
        public readonly int PartOne = 1, PartTwo = 2;
        public readonly IInputHandler InputHandler = new InputHandler(2023);
    }
}
