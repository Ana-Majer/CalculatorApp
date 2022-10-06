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
        public Form1()
        {
            InitializeComponent();
            operations = new Dictionary<string, Func<double, double, double>>();
            operations.Add("+", (x, y) => x + y);
            operations.Add("-", (x, y) => x - y);
            operations.Add("x^(1/y)", (x, y) => Math.Pow(x, 1 / y));

            list_operations.Items.Add("+");
            list_operations.Items.Add("-");
            list_operations.Items.Add("x^(1/y)");
        }



        private void list_operations_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double operand1 = double.Parse(textBox1.Text);
            string operation = (string)list_operations.SelectedItem;
            double operand2 = double.Parse(textBox2.Text);
            double result = operations[operation](operand1, operand2);
            listView1.Items.Add(result.ToString());

        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {

        }
    }
}
