using CalcForm;
using NUnit.Framework;

namespace CalculatorAppTest
{
    class MultiTest
    {
        [TestCaseSource(nameof(Parameters))]
        public void PositiveTest(double a, double b, double expected)
        {
            double actual = OperationsFactory.getOperations()["*"](a, b);
            Assert.AreEqual(expected, actual);
        }

        public static readonly object[] Parameters =
        {
          new object [] { 4, 8, 32 }   ,
          new object [] { 7, 8, 56 }   ,
          new object [] { -21, 6, -126 }   ,

        };
    }
}
