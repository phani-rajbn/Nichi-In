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
    public partial class ProductFind : Form
    {
        public ProductFind()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //get the value of the txtBox
            var name = txtSearch.Text;
            //call the FindProduct method frmo the component and pass the value
            var table = MainForm.component.FindProduct(name);
            //Set the resutl to the grid
            grdTable.DataSource = table;
        }
    }
}
