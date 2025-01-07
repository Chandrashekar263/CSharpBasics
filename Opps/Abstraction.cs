using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public abstract class AreaClass  //abstractclass
    {
       public abstract int Area();

    }
    class Sqaure : AreaClass
    {
        int side = 0;
        //constructor
        public Sqaure(int n)
        {
            side = n;
        }
        public override int Area()
        {
            //return side * side;
            return side + side;
        }
        ~Sqaure()      //distructor is use to remove unused data Garbage collector
        {
        }
        class Abc
        {
            public static void Main(string[] args)
            {
                Sqaure s = new Sqaure(6);
                Console.WriteLine(s.Area());
                Console.ReadKey();

            }
        }
    }
        

    
    
    
}
