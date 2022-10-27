using CalcForm;
using NUnit.Framework;
namespace CalculatorAppTest
{
    class PowSqrtTest
    {
        [TestCaseSource(nameof(Parameters))]
        public void PositiveTest(double a, double b, double expected)
        {
            double actual = OperationsFactory.getOperations()["x^(1/y)"](a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }

        public static readonly object[] Parameters =
        {
          new object [] { 4, 8, 1.189 }   ,
          new object [] { 7, 8, 1.275 }   ,
          new object [] { 21, 6, 1.661 }   ,
          new object [] { -21, 6, double.NaN }   ,
          new object [] { 0, 6, 0 }   ,



        };
    }
}
