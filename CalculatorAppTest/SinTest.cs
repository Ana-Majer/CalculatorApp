using CalcForm;
using NUnit.Framework;

namespace CalculatorAppTest
{
    class SinTest
    {
        [TestCaseSource(nameof(Parameters))]
        public void PositiveTest(double a, double expected)
        {
            double actual = OperationsFactory.getOperations()["sin"](a, 0);
            Assert.AreEqual(expected, actual, 0.001);
        }

        public static readonly object[] Parameters =
        {
          new object [] { 4, 0.069 }   ,
          new object [] { 7, 0.121 }   ,
          new object [] { -21, -0.358 }   ,

        };
    }
}
