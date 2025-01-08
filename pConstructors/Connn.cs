using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pConstructors
{
    public class Start
    {
        static void Named(int a, int b)//named parameters
        {

            Console.WriteLine("sum = " + (a - b));//+ symbol Concatination
        }
        static void Reference(ref int v1)//Reference type
        {
            Console.WriteLine("Increment\t" + ++v1);
        }
        static void Main(string[] args)
        {
            int v = 3;
            Named(a: 12, b: 2);//calling method
            Reference(ref v);//reference
            Console.WriteLine(v);


            Console.WriteLine("just learn c#");
        }
    }
}


