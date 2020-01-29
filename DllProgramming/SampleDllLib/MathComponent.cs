using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDllLib
{
    //When the class is declared as public, it is made accessible outside this project
    public class MathComponent
    {
        public double AddFunc(double v1, double v2) => v1 + v2;

        public double SubFunc(double v1, double v2) => v1 - v2;
    }
}
