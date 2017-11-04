using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator_window : Form
    {
        public Calculator_window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void click_button(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if (textBox_Result.Text == "0")
                {
                    textBox_Result.Clear();
                }
            textBox_Result.Text = textBox_Result.Text + s;
        }
    }
}
