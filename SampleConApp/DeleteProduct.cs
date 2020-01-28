using System;
using System.Windows.Forms;

namespace SampleConApp
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            //Get All the records...
            var data = MainForm.component.FindProduct(string.Empty);
            
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";
            comboBox1.DataSource = data;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do U really want to delete", "Delete Product", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            try
            {
                int id = Convert.ToInt32(comboBox1.SelectedValue);
                MainForm.component.RemoveProduct(id);
                MessageBox.Show("Product removed from the database");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
