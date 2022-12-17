using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForm
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Словарь операций 
        /// </summary>
        private Dictionary<string, Func<double, double, double>> operations;
        /// <summary>
        /// Список унарных операций 
        /// </summary>
        private List<string> UnaryOperations;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            operations = OperationsFactory.getOperations();
            UnaryOperations = OperationsFactory.getUnaryOperations();
            list_operations.Items.Add("+");
            list_operations.Items.Add("-");
            list_operations.Items.Add("/");
            list_operations.Items.Add("*");
            list_operations.Items.Add("^");
            list_operations.Items.Add("x^(1/y)");
            list_operations.Items.Add("sin");
            list_operations.Items.Add("cos");
            list_operations.Items.Add("tg");
        }

        /// <summary>
        /// Обработчик события изменения индекса в списке операций
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void list_operations_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = !UnaryOperations.Contains(list_operations.SelectedItem);
        }

        /// <summary>
        /// Обработчик события "нажатие на кнопку "Вычислить""
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double operand1 = ParseTextBoxValue(textBox1);
            string operation = (string)list_operations.SelectedItem;
            double operand2 = ParseTextBoxValue(textBox2);
            double result = operations[operation](operand1, operand2);
            listBox1.Items.Insert(0, result.ToString());
        }

        /// <summary>
        /// Получает значения из поля ввода
        /// </summary>
        /// <param name="textBox">Поле ввода</param>
        /// <returns>Значение типа double</returns>
        private double ParseTextBoxValue(TextBox textBox)
        {
            if (textBox.TextLength == 0) return 0;
            else return double.Parse(textBox.Text);
        }

        /// <summary>
        /// Обработчик события "нажатие на кнопку "Очистить все поля""
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
