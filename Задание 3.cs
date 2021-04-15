using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                X = 8,
                Y = 12,
                Expected = 20,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                X = 4,
                Y = 6,
                Expected = 10,
                ExpectedException = null
            };

            TestSum(testCase1);
            TestSum(testCase2);

        }
    }
}
