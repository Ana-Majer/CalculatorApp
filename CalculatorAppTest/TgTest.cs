using CalcForm;
using NUnit.Framework;

namespace CalculatorAppTest
{
    class TgTest
    {
        [TestCaseSource(nameof(Parameters))]
        public void PositiveTest(double a, double expected)
        {
            double actual = OperationsFactory.getOperations()["tg"](a, 0);
            Assert.AreEqual(expected, actual, 0.001);
        }

        public static readonly object[] Parameters =
        {
          new object [] { 4, 0.069 }   ,
          new object [] { 7, 0.122 }   ,
          new object [] { -21, -0.383 }   ,
          new object [] { 0, 0 }   ,

        };
    }
}
