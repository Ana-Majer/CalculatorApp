using CalcForm;
using NUnit.Framework;

namespace CalculatorAppTest
{
    class PowTest
    {
        [TestCaseSource(nameof(Parameters))]
        public void PositiveTest(double a, double b, double expected)
        {
            double actual = OperationsFactory.getOperations()["^"](a, b);
            Assert.AreEqual(expected, actual);
        }

        public static readonly object[] Parameters =
        {
          new object [] { 4, 8, 65536 }   ,
          new object [] { 7, 8, 5764801 }   ,
          new object [] { -21, 6, 85766121 }   ,
          new object [] { 4, 1000, double.PositiveInfinity}   ,


        };
    }
}
