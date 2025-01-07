using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessmofierexamples
{



      class DEmo
        {
        internal void Modifear()
        {
            Console.WriteLine("Private Acess modifier");
        }
    }

        public class Program 
        {
        private void demo()
        {
            Console.WriteLine("AcessModifer");
        }
        
        
           static void Main(string[] args)
        {
            Program p = new Program();
            DEmo demo = new DEmo(); 
            p.demo();
            demo.Modifear();
            Console.Write("hello C sharp");
            Console.WriteLine("welocome to hyderbad");
            Console.Write("hello C sharp");
            Console.WriteLine("welocome to hyderbad");
            Console.ReadKey();
        }
    }
}


    
       



        
    


