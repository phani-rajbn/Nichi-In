using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinApp
{
    public partial class EmployeeCtrl : UserControl
    {
        public event Action Submit; 
        public EmployeeCtrl()
        {
            InitializeComponent();
        }

        public Employee Employee { get; set; }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Employee = new Employee();
            Employee.EmpID = int.Parse(txtID.Text);
            Employee.EmpName = txtName.Text;
            Employee.EmpAddress = txtAddress.Text;
            Employee.EmpSalary = double.Parse(txtSalary.Text);
            Submit();
        }
    }

}
