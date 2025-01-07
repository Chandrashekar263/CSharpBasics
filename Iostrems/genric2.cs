using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genricc;


namespace Genricc
{
     class Program<T>
    {                   //Geenric Class
        public void swap(T a, T b)
        {
            //here T is genric type passed by user
            //genric method under generic class
            //denrics is used to call a multipule data types by phaseholder
            T temp = a;
             a = b;
            b= temp;
            Console.WriteLine("after swap\na="+ a +"\tb=" + 
                b );
        }
        public void print(T course)
        {
            Console.WriteLine("Just learn " + course + "\twith python life");
        }
    }
}
class driver
{


    static void Main(string[] args)
    {
        Program<int> g = new Program<int>();
        int a = 4, b = 5;
        Console.WriteLine("before swap\n a=" + a + "\t b="+ b);
        g.swap(a, b);

        Program<string> g1 = new Program<string>();
        Console.WriteLine("Enter a Course name");
        string c = Console.ReadLine();
        g1.print(c);

        Console.ReadKey();
    }

}


