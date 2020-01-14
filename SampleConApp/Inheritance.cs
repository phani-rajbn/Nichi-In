using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class BaseClass
    {
        public void SimpleFunction()
        {
            Console.WriteLine("Simple Function in the base class");
        }
    }

    class DerivedClass : BaseClass
    {
        public void SampleFunction()
        {
            Console.WriteLine("Sample Function from the derived class");
        }
    }
    class Inheritance
    {
        static void Main(string[] args)
        {

            BaseClass cl = new BaseClass();
            cl.SimpleFunction();

            DerivedClass dl = new DerivedClass();
            dl.SampleFunction();//Its own method
            dl.SimpleFunction();//From its base class. 
        }
    }
}
