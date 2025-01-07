//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace pConstructors
//{

//    class program              //copy constructor 
//    {
//        //       static void Main(string[] args)
//        //       {

//        //       }   
//        //}

//        private string month;
//        private int year;
//        private int day;


//        public program(program s)//like a object
//        {
//            month = s.month;
//            year = s.year;
//            day = s.day;    
//        }

//        public program(string month, int year,int day)
//        {
//            this.month = month;
//            this.year = year;
//            this.day=day;

//        }
//        public string Detials
//        {
//            get
//           {
//                return "month: " + month.ToString() +
//                    "\nYear:" + year.ToString() + "\nday: " + day.ToString();
//            }
//        }


//        static void Main(string[] args)
//        {
//            Console.WriteLine("Copy Constructor");
//            program g1 = new program("Aug", 2024,28);
//            program g2 = new program(g1);

//            Console.WriteLine(g2.Detials);
//            Console.ReadLine();


//        }
//        //    }
//        //}
//        //{
//        //public Demo()
//        //{
//        //    Console.WriteLine("Default constructor");  //Default Constructor
//        //}
//        //public Demo(int a, int b)//Paramerized construtor
//        //{
//        //    Console.WriteLine("a+b=" + (a + b));
//        //}
//        //        private Demo()
//        //        {
//        //            Console.WriteLine("Private Constructor");
//        //        }
//        //static void Main(string[] args)
//        // {
//        //            Console.WriteLine("Constructors");
//        //           // Demo demo = new Demo(1,2);//passing parameters
//        //             Demo d = new Demo();//for private name changed to usnterstand
//        //            Console.ReadLine();
//    }
//}






