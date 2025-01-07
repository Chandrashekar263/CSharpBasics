using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBridInheritance
{
    public class Hybridbass
    {
        public void high()
        {
            Console.WriteLine("Hybrid Class");
        }
    }
            interface Inter1
        {
            void Show();//Declaration
        }

        class Base1 : Hybridbass, Inter1
        {
            public void Show()
            {
                Console.WriteLine("Base1 Class Method ");//defination
            }
        }
        interface Inter2
        {
            void display();
        }
        class Base2 : Hybridbass ,Inter2
        {
            public void display()
            {
                Console.WriteLine("Base2 Class method");

            }

            class Derived : Inter1, Inter2
            {
                Base1 base1 = new Base1();
                Base2 base2 = new Base2();

                public void Show()
                {
                    base1.Show();
                    base1.high();
                }
                public void display()
                {
                    base2.display();
                    base2.high();
                }
            }


            //Driver class
            public class InterfaceExample
            {
                static public void Main(string[] args)
                {
                    Derived derived = new Derived();
                    derived.Show();
                    derived.display();
                    Console.ReadLine();
                }
            }
        }
    }


    

