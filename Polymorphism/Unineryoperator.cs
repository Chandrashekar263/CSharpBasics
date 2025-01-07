//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Polymorphism
//{
//    public class Calculator
//    {
//        public int number1, number2;
//        public Calculator(int num1, int num2)
//        {
//            number1 = num1;
//            number2 = num2;


//        }
//        public static Calculator operator -(Calculator c1)
//        {
//            c1.number1 = -c1.number1;
//            c1.number2 = -c1.number2;
//            return c1;
//        }
//        public void print()
//        {
//            Console.WriteLine("number1=" + number1);
//            Console.WriteLine("number2=" + number2);
//        }
//        static void Main(string[] args)
//        {
//            Calculator calc = new Calculator(15, -25);
//            calc = -calc;
//            calc.print();
//            Console.ReadLine();




//        }


//    }
//}
