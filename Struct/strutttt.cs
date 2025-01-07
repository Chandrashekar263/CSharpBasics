using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct person
    {
        //declaring different data types
        public string Name;
        public int Age;
        public int Weight;
        public int hight;
    }
   enum Days { sun,mon,the,wed,thur,fry,sat};
    class Program
    {
        //main method
        static void Main(string[] args)
        {
            //Declere P1 of type person
            // person P1;//Like this also you can create object

            person P1 = new person();
                                  //P1's data
            P1.Name = "Chandu";
            P1.Age = 19;
            P1.Weight = 72;
            P1.hight = 6;

            //Displaying the values
            //Console.WriteLine("Data stored in  p1 is "+P1.Name+",age is "+P1.Age+"\tand weight is "+P1.Weight+"hight is\t"+P1.hight);
           Console.WriteLine("Data stored in  p1 is {0},age is {1} and weight is {2}and hight is {3}",P1.Name,P1.Age,P1.Weight,P1.hight); 
            

            //enumuration
            int weekdaystart = (int)Days.mon;
            int weekdayEnd = (int)Days.fry;
            int weekday = (int)Days.sat;


            Console.WriteLine(Days.mon);
            Console.WriteLine("monday:{0}", weekdaystart);
            Console.WriteLine("fryday:{0}",weekdayEnd);
            Console.WriteLine("sunday:{0}", weekday);
            Console.ReadKey();




        }
    }
    
    
}
