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
        private Dictionary<char, Func<int, int, double>> operations;
        public Form1()
        {
            InitializeComponent();
            operations = new Dictionary<char, Func<int, int, double>>();
            operations.Add('+', (x, y) => x + y);
            operations.Add('-', (x, y) => x - y);

            list_operations.Items.Add("+");
            list_operations.Items.Add("-");
        }

        

        private void list_operations_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int operand1 = int.Parse(textBox1.Text);
            char operation = ((string)list_operations.SelectedItem)[0];
            int operand2 = int.Parse(textBox2.Text);
            double result = operations[operation](operand1, operand2);
            listView1.Items.Add(result.ToString());

        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {

        }
    }
}
