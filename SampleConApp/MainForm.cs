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
    using SampleConApp.Dal;
    public partial class MainForm : Form
    {
        public static IProductDataLib component = new ProductDatabase();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        //Event Handler..
        private void ExitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //U should close the Application..
            Application.Exit();//To Exit the Application...
        }

        private void AddNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct();
            frm.ShowDialog(this);
        }

        private void FindProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductFind frm = new ProductFind();
            frm.ShowDialog(this);
        }

        private void RemoveProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct frm = new DeleteProduct();
            frm.ShowDialog(this);
        }

        private void AskMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question frm = new Question("Please enter UR Name:");
            frm.ShowDialog();//Pause the App execution...
            //frm.Answer = "Testing123";
        }
    }
}
