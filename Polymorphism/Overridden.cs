//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Polymorphism;

//namespace Polymorphism
//{
//    internal class Help
//    {
//        string name = "python life";
//        public virtual void showdata()
//        {
//            Console.WriteLine("Name:"+name);

//        }
//    }
//}
//class Steam: Help
//{
//    string name2 = "Coumpter Science";
//    public override void showdata()
//    {
//        base.showdata();//no need to create object

//        Console.WriteLine("About:"+name2);

//    }
//    static void Main(string[] args)
//    {
//        Steam steam = new Steam();
//        steam.showdata();

//        //Help help = new Help();//[if we use base method ,like base.showdata(); noneed to create object
//       // help.showdata();

//        Console.WriteLine("LearnC#");
//        Console.ReadLine();


//    }
//}