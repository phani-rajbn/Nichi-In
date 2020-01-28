using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleConApp
{
    public partial class Question : Form
    {
        public string Answer { get; private set; }
        public Question()
        {
            InitializeComponent();
        }

        public Question(string question) : this()
        {
            
            lblQuestion.Text = question;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Answer = textBox1.Text;
            this.Close();
        }
    }
}
