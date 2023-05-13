using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathNamespace
{
    public class MyMath
    {
        static public double Volume(string str)
        {
            double volume = 0;
            try
            {
                double length = double.Parse(str);
                volume = length * length * length;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return volume;
        }
    }
}
