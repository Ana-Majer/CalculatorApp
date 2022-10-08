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
    public partial class Form1 : Form
    {
        private Dictionary<string, Func<double, double, double>> operations;
        private List<string> UnaryOperations;

        public Form1()
        {
            InitializeComponent();
            operations = new Dictionary<string, Func<double, double, double>>();
            operations.Add("+", (x, y) => x + y);
            operations.Add("-", (x, y) => x - y);
            operations.Add("x^(1/y)", (x, y) => Math.Pow(x, 1 / y));
            operations.Add("cos", (x, y) => Math.Cos(x));

            UnaryOperations = new List<string>();
            UnaryOperations.AddRange(new List<string>() { "sin", "cos", "tg" });

            list_operations.Items.Add("+");
            list_operations.Items.Add("-");
            list_operations.Items.Add("x^(1/y)");
            list_operations.Items.Add("cos");
        }

        private void list_operations_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = !UnaryOperations.Contains(list_operations.SelectedItem);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double operand1 = ParseTextBoxValue(textBox1);
            string operation = (string)list_operations.SelectedItem;
            double operand2 = ParseTextBoxValue(textBox2);
            double result = operations[operation](operand1, operand2);
            listView1.Items.Add(result.ToString());
        }

        private double ParseTextBoxValue(TextBox textBox)
        {
            if (textBox.TextLength == 0) return 0;
            else return double.Parse(textBox.Text);
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {

        }
    }
}
