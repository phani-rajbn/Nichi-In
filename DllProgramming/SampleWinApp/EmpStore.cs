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
    using EmployeeBOLib;
    public partial class EmpStore : Form
    {
        private IEmpBO bo = new EmpBOComponent();
        public EmpStore()
        {
            InitializeComponent();
        }

        private void EmployeeCtrl1_Submit()
        {
            var emp = new EntitiesLib.Employee();
            emp.EmpID = employeeCtrl1.Employee.EmpID;
            emp.EmpName = employeeCtrl1.Employee.EmpName ;
            emp.EmpAddress = employeeCtrl1.Employee.EmpAddress;
            emp.EmpSalary = employeeCtrl1.Employee.EmpSalary ;
            bo.AddNewEmployee(emp);
            
        }
    }
}
