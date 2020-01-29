using SampleDllLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinApp
{
    public partial class CalcForm : Form
    {
        private double firstValue, secondValue, result;
        private string operand;
        private MathComponent com = new MathComponent();
        private void Operand_Click(object sender, EventArgs e)
        {
            //Store the current value of the lbl into firstValue...
            firstValue = double.Parse(lblDisplay.Text);
            lblDisplay.Text = string.Empty;
            operand = ((Button)sender).Text;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secondValue = double.Parse(lblDisplay.Text);
            switch (operand)
            {
                case "+":
                    result = com.AddFunc(firstValue, secondValue);
                    lblDisplay.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }

        public CalcForm()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var selectedBtn = sender as Button;
            lblDisplay.Text += selectedBtn.Text;
            var value = double.Parse(lblDisplay.Text);
            lblDisplay.Text = value.ToString();
        }
    }
}
