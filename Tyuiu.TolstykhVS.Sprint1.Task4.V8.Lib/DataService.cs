using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TolstykhVS.Sprint1.Task4.V8.Lib
{
    public class DataService : ISprint1Task4V8
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Sqrt(Math.Abs(x - y)) + 3 * x) / (3 + x);
            return res; 
        }
    }
}
