using CalcForm;
using NUnit.Framework;

namespace CalculatorAppTest
{
    class DivTest
    {
        [TestCaseSource(nameof(Parameters))]
        public void PositiveTest(double a, double b, double expected)
        {
            double actual = OperationsFactory.getOperations()["/"](a, b);
            Assert.AreEqual(expected, actual);
        }

        public static readonly object[] Parameters =
        {
          new object [] { 4, 8, 0.5 }   ,
          new object [] { 7, 8, 0.875 }   ,
          new object [] { -21, 6, -3.5 }   ,
          new object [] { 4, 0, double.PositiveInfinity}   ,
          new object [] { 0, 6, 0 }   ,


        };
    }
}
