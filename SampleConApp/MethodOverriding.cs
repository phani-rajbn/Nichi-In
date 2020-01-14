using System;

namespace SampleConApp
{
    class BaseClass
    {
        public virtual void TestFunc()
        {
            Console.WriteLine("Test Func");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void TestFunc()
        {
            Console.WriteLine("All new features");
            base.TestFunc();
        }
    }
    class MethodOverriding
    {
        static void Main(string[] args)
        {
            BaseClass obj = new BaseClass();
            obj.TestFunc();
            
            obj = new DerivedClass();//Luskov's substitution principle...
            obj.TestFunc();
            
        }
    }
}
