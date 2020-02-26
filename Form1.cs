using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntitiesLib;
using BusinessLib;
namespace SampleWinApp
{
    public partial class MainForm : Form
    {
        static IEmployeeComponent component = EmployeeFactory.GetComponent();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                lstNames.DataSource = component.GetAllEmployees();
                lstNames.ValueMember = "EmpID";
                lstNames.DisplayMember = "EmpName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var emp = lstNames.SelectedItem as Employee;
            txtID.Text = emp.EmpID.ToString();
            txtName.Text = emp.EmpName;
            txtAddress.Text = emp.EmpAddress;
            txtSalary.Text = emp.EmpSalary.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text.Contains("Add"))
            {
                try
                {
                    Employee uEmployee = new Employee();
                    uEmployee.EmpID = 0;
                    uEmployee.EmpName = txtName.Text;
                    uEmployee.EmpAddress = txtAddress.Text;
                    uEmployee.EmpSalary = double.Parse(txtSalary.Text);
                    component.AddEmployee(uEmployee);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Employee uEmployee = new Employee();
                    uEmployee.EmpID = int.Parse(txtID.Text);
                    uEmployee.EmpName = txtName.Text;
                    uEmployee.EmpAddress = txtAddress.Text;
                    uEmployee.EmpSalary = double.Parse(txtSalary.Text);
                    component.UpdateEmployee(uEmployee);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MainForm_Load(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Add new Employee";
            btnUpdate.Text = "Add Employee";
            txtID.Enabled = true;
            allClear();
        }

        private void allClear()
        {
            
            foreach(var control in groupBox1.Controls)
            {
                if(control is TextBox)
                {
                    var tBox = control as TextBox;
                    tBox.Text = string.Empty;
                }
            }
        }

        private void LstNames_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void LstNames_KeyDown(object sender, KeyEventArgs e)
        {
            var emp = (lstNames.SelectedItem as Employee).EmpName;
            if(e.KeyCode == Keys.Delete)
            {
                var res = MessageBox.Show($"Do U want to delete the Employee by name {emp}?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (res == DialogResult.Yes)
                {
                    try {
                        component.DeleteEmployee(Convert.ToInt32(lstNames.SelectedValue));
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MainForm_Load(sender, e);
        }
    }
}
