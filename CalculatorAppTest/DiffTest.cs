using CalcForm;
using NUnit.Framework;

namespace CalculatorAppTest
{
    class DiffTest
    {
        [TestCaseSource(nameof(Parameters))]
        public void PositiveTest(double a, double b, double expected)
        {
            double actual = OperationsFactory.getOperations()["-"](a, b);
            Assert.AreEqual(expected, actual);
        }

        public static readonly object[] Parameters =
        {
          new object [] { 4, 8, -4 }   ,
          new object [] { 7, 8, -1 }   ,
          new object [] { -21, 6, -27 }   ,

        };
    }
}
