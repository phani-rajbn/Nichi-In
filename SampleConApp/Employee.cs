using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Every class is implicitly dirived from System.Object. Object class has a method called GetHashCode that can be ovverriden to provide UR own Hashcode implementation..
namespace SampleConApp
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }
        public override int GetHashCode()
        {
            return EmpID.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(obj is Employee)
            {
                var temp = obj as Employee;//Unboxing syntax for Reference types....
                return ((temp.EmpID == EmpID) && (temp.EmpName == EmpName));
            }
            return false;
        }
    }
}
