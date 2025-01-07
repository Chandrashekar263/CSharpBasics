//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Polymorphism
//{ 
//class Caiculator//OPERATOR OVER LOADING (-) Binery over load
//{
//    public int number = 0;
//    public Caiculator() { }
//    public Caiculator(int n)
//    {
//        number = n;
//    }
//    public static Caiculator operator -(Caiculator Calc1, Caiculator Calc2)
//    {
//        Caiculator CalC3 = new Caiculator();
//        CalC3.number = Calc1.number - Calc2.number;
//        return CalC3;
//    }
//    public void display()
//    {
//        Console.WriteLine("{0}", number);
//    }
//    public static void Main(string[] args)//we can create number of objects for same class
//    {
//        Caiculator num1 = new Caiculator(100);
//        Caiculator num2 = new Caiculator(40);
//        Caiculator num3 = new Caiculator();

//        num3 = num1 - num2;
//       // num2 = num2 - num3;


//        num1.display();
//        num2.display();
//        num3.display();
//        Console.ReadLine();
//    }
//}
//}





