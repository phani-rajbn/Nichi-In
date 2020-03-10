using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public interface IExample
    {
        string showMe();
    }
    public class Examplev1 : IExample
    {
        public string showMe()
        {
            return "First version";
        }
    }

    public class Examplev2 : IExample
    {
        public string showMe()
        {
            return "Second version";
        }
    }

    public class Examplev3 : IExample
    {
        public string showMe()
        {
            return "Third version";
        }
    }
    public class Examplev4 : IExample
    {
        public string showMe()
        {
            return "Fourth version";
        }
    }
    public class Factory
    {
        public static IExample GetComponent()
        {
            var name = ConfigurationManager.AppSettings["myClass"];
            switch (name)
            {
                case "Examplev1":
                    return new Examplev1();
                case "Examplev2":
                    return new Examplev2();
                case "Examplev3":
                    return new Examplev3();
                case "Examplev4":
                    return new Examplev4();
                default:
                    return null;
            }
        }
    }
}
