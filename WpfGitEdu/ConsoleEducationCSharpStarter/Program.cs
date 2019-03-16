using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEducationCSharpStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            double op1 = 4.6;
            double op2 = -34.72;
            double sum, dif, mul, div;
            sum = op1 + op2;
            dif = op1 - op2;
            mul = op1 * op2;
            div = op1 / op2;

            Console.WriteLine("{0:f1}{1}{2:f2}={3:f2}", op1,'+', op2, sum);
            Console.WriteLine("{0:f1}{1}{2:f2}={3:f2}", op1,'-', op2, dif);
            Console.WriteLine("{0:f1}{1}{2:f2}={3:f2}", op1,'*', op2, mul);
            Console.WriteLine("{0:f1}{1}{2:f2}={3:f2}", op1,'/', op2, div);
            Console.ReadKey();
        }
    }
}
