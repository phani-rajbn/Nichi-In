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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtProductId.Text);
            var name = txtProductName.Text;
            var price = int.Parse(txtProductPrice.Text);
            var stock = int.Parse(cmbStock.Text);
            MainForm.component.AddProduct(id, name, price, stock);
            MessageBox.Show("Inserted successfully!!!");
            this.Close();
        }

        private void TxtProductPrice_Validating(object sender, CancelEventArgs e)
        {
            int res = 0;
            if (!int.TryParse(txtProductPrice.Text, out res))
            {
                //MessageBox.Show("Should enter numbers only");
                e.Cancel = true;
                errorProvider1.SetError(txtProductPrice, "Should enter numbers only");
            }
            else
            {
                errorProvider1.SetError(txtProductPrice, "");
                e.Cancel = false;
            }
        }
    }
}
