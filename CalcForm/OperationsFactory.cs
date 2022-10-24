using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    public class OperationsFactory
    {
        public static Dictionary<string, Func<double, double, double>> getOperations()
        {
            Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>();
            operations.Add("+", (x, y) => x + y);
            operations.Add("-", (x, y) => x - y);
            operations.Add("/", (x, y) => x / y);
            operations.Add("*", (x, y) => x * y);
            operations.Add("^", (x, y) => Math.Pow(x, y));
            operations.Add("x^(1/y)", (x, y) => Math.Pow(x, 1 / y));
            operations.Add("sin", (x, y) => Math.Sin(x));
            operations.Add("cos", (x, y) => Math.Cos(x));
            operations.Add("tg", (x, y) => Math.Tan(x));
            return operations;
        }
        public static List<string> getUnaryOperations()
        {
            var UnaryOperations = new List<string>();
            UnaryOperations.AddRange(new List<string>() { "sin", "cos", "tg" });
            return UnaryOperations;
        }
    }
}
