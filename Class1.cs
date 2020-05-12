using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public class Class1
    {
        double aria (double ariaСircle)// Вычисление площади круга
        {
            return Math.PI * Math.Pow(ariaСircle, 2); 
        }
        double aria (double a, double b, double c)// Вычесление площади треугольника по трем сторонам
        {
            double P = (a + b + c) / 2;

            return Math.Sqrt(P*(P - a)*(P - b)*(P - c)); //
        }
    }
}
