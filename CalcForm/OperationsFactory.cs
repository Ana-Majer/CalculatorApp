using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    /// <summary>
    /// Создает списки операций и выполняет преобразования
    /// </summary>
    public class OperationsFactory
    {
        /// <summary>
        /// Создает словарь операций
        /// </summary>
        /// <returns>Словарь операций</returns>
        public static Dictionary<string, Func<double, double, double>> getOperations()
        {
            Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>();
            operations.Add("+", (x, y) => x + y);
            operations.Add("-", (x, y) => x - y);
            operations.Add("/", (x, y) => x / y);
            operations.Add("*", (x, y) => x * y);
            operations.Add("^", (x, y) => Math.Pow(x, y));
            operations.Add("x^(1/y)", (x, y) => Math.Pow(x, 1 / y));
            operations.Add("sin", (x, y) => Math.Sin(ToRad(x)));
            operations.Add("cos", (x, y) => Math.Cos(ToRad(x)));
            operations.Add("tg", (x, y) => Math.Tan(ToRad(x)));
            return operations;
        }

        /// <summary>
        /// Переводит градусы в радианы
        /// </summary>
        /// <param name="grad">Угол в градусах</param>
        /// <returns>Угол в радианах</returns>
        private static double ToRad(double grad)
        {
            return grad * Math.PI / 180;
        }

        /// <summary>
        /// Создает список унарных операций
        /// </summary>
        /// <returns>Список унарных операций</returns>
        public static List<string> getUnaryOperations()
        {
            var UnaryOperations = new List<string>();
            UnaryOperations.AddRange(new List<string>() { "sin", "cos", "tg" });
            return UnaryOperations;
        }
    }
}
