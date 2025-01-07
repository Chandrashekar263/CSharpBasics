using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance//Multi level inheritance
{
     class UpperBase
    {
        public void Multi()
        {
            Console.WriteLine("Upper base Class");
        }
    }
    
        class Base:UpperBase
        {
            public void Show()
            {
                Console.WriteLine("Base Class");
            }
        }
        class Derived : Base
        {
            public void Display()
            {
                Console.WriteLine("Drived Class");
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Main Class");
                Derived derived = new Derived();
                derived.Show();
                derived.Display();
                derived.Multi();
                Console.ReadLine();

            }
        }
    }


