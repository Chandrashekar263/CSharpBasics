using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Colint
    {
        public static void Main(string[] args)
        {
            List<int> mylist = new List<int>();

            for (int j = 5; j <9; j++)
            {
                mylist.Add(j * 3);
            }
            Console.WriteLine("Colletions");
            foreach (int items in mylist)
            {
                Console.WriteLine("\t" + items);


            }
        }
    }
}

