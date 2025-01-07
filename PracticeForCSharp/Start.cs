using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForCSharp
{
    
    public class Start
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("just learn c# In youtube");
            // DataTypes();
            // variables();
            // Variable();
            // Array();
            // Operator();
            // Strings();
            //TypeConversion();
            //ConditionalStatements();
            //whilestatments();
            //ForLoop();
            //nestedloop();
            //infinatenestedloop();
            //GoToO();
            
            Console.ReadKey();
        }
        
        static void DataTypes()
        {
           
            int a = 500;
            Console.WriteLine(a.GetType());

            //float data tye
            float f = 8.2222f;
            Console.WriteLine(f.GetType());

            //Boolean Data Type
            bool b = true;
            Console.WriteLine(b.GetType());

            // Character Data Type
            char c = 'a';
            Console.WriteLine(c.GetType());

            double d = 7676.77;
            Console.WriteLine(d.GetType());

            //String  Data Type
            String s = "CsharpTraning";

            Console.WriteLine(s.GetType());
            Console.Write("mattaparthi");
            Console.Write("Chandrashekar");
            Console.Write("manikantaswamy");

            // Different Types Of Data Types
            //Integer Data Type


            //Variable

            //variable = name type value
            // int b= 56;
            // data type = int,name= b,value= 56

        }
        static void Variable()
        {
            /*Decalration of variable
             * Intilization of variable
             * Run time and compile time intilization
             */
            int ChanduAge = 28;
            Console.WriteLine("ChanduAge is {0}", ChanduAge);
            Console.WriteLine("Enter your Age");

            int SaiAge1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ChanduAge{0} SaiAge is {1}", ChanduAge, SaiAge1);

        }
        static void variables()
        {
            int Chandu = 23;
            Console.WriteLine("Chandu is {0}", Chandu);
            Console.WriteLine("Age");
            int shekar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chandu{0} Shekar is {1}", Chandu, shekar);
            int SaiAge1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chandu{0} shekar is {1} SaiAge is {2}", Chandu, shekar, SaiAge1);
        }
        static void Array()
        {
            //initialization of aaray
            //Example1
            //Defining array wwith size 5.But not assinging values
            int[] intArray1 = new int[5];
            //Example 2
            // defining array with 5 and assigning the values at same time
            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };
            //Example 3
            //defining array with 5 elements which indicates the size of array
            int[] intArray3 = { 1, 2, 3, 4, 5 };


            // 1 dimensional array
            Console.WriteLine("1-D array elements:");
            foreach (int d in intArray3)
                Console.Write(d + "");
            Console.WriteLine();

            //2 dimensional array
            int[,] _2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            Console.WriteLine("2-D array elements:");
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(_2D[i, j] + "");
            Console.WriteLine();



            //3 dimensional array
            int[,,] _3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6, }, { 5, 7, 8 } } };
            //jaggedarray
            int[][] J_A = new int[2][];
            //initilize the elements
            J_A[0] = new int[5] { 1, 3, 5, 7, 9 };
            J_A[1] = new int[4] { 2, 4, 6, 8, };
            //Another way to Declare the elements
            int[][] J_A1 = { new int[] { 1, 3, 5, 7, 9 } ,
            new int[] { 2, 4, 6, 8 } };
            //Display the jagged array elements
            for (int i = 0; i < J_A.Length; i++)
            {
                Console.WriteLine("jagged array elements:");
                Console.Write("Element[" + i + "]Array:");
                for (int j = 0; j < J_A[i].Length; j++)
                    Console.Write(J_A[i][j] + "");
                Console.WriteLine();
            }

        }
        static void Operator()
        {
            //Arithmetic operation
            int a = 10, b = 20;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);
            Console.WriteLine(a / b);
            //Realational Operators
            Console.WriteLine("Realational operator");
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);// ! Not equal to
            //Assignment OPerator
            Console.WriteLine("Assignment");
            Console.WriteLine(a = b);//(means a=20)
            Console.WriteLine(a += 10);//(30)
            //a=a+10;
            Console.WriteLine(a -= 10);//(20)

            //Unaruy operator
            Console.WriteLine(a++);//post increment 21
            Console.WriteLine(a);
            Console.WriteLine(++a);//pre increment
            Console.WriteLine(a);//out put
            Console.WriteLine(--a);//pre decrement
            Console.WriteLine(a--);//post decriment
            Console.WriteLine(a--);

            // ternery operator
            Console.WriteLine("ternary operator");
            Console.WriteLine(a > b ? b : a);

            //Logical operator//
            Console.WriteLine("Logical Operator");
            Console.WriteLine(a > b && a < b);
            Console.WriteLine(a > b || a < b);
            Console.WriteLine(a);//19
            Console.WriteLine(b);//20
            //bool
            bool t = true;
            Console.WriteLine(!t);


        }
        static void Strings()
        {
            /* string
            *string variable_name = "value/text";
            *Reference ,immutable,contains nulls,its over loads the operator (==)
            *String Array
            *syntex
            *String[] array _variable= new String[length _of_array];
            *Example
            *String[]str_array= new String[python(0),life(1),chandu(2)];
            */
            string a = "learning the c Sharp Language";
            Console.WriteLine(a);
            string[] b = new string[3];
            b[0] = "Learning";
            b[1] = "C Sharp";
            b[2] = "Visual stidio";
            for (int i = 0; i < 3; i++)
                Console.WriteLine(b[i]);
            // concatenation
            //Example
            string ABC = b[0] + b[1] + b[2];
            Console.WriteLine(ABC);
            //Example
            string ABCD = b[0] + b[1] + "C#";
            Console.WriteLine(ABCD);
            //Example
            string Chandu = b[0] + "hi how are you" + b[1] + b[2] + "hi";
            Console.WriteLine(Chandu);
            //Example
            int T = 100;
            string f = String.Format("{0}{1}", a, T.ToString());
            Console.WriteLine(f);
            //Example
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();//user input
            Console.WriteLine(name);

        }
        static void TypeConversion()
        {
            /*TYPE CASTING
         * int a=12;
         * float b=a;//now b value is 12.0(implict coverstion)
         * Explict type converstion
         * int a=12
         * stringb= Convert.ToString(a);//now b value is 12 as a string
         * float is bigger data type ,int is smaller data type
          **/
            //Type Casting/Type converstion

            int a = 100;//(implict coverstion)
            float b = a;
            Console.WriteLine(b);

            //Explictwait{data loss}
            float c = 2.34f;
            int d = Convert.ToInt32(c);
            Console.WriteLine(d);

            //Float to String no data loss
            string s = Convert.ToString(c);
            Console.WriteLine("float to string converstion {0}", s);
        }

        static void ConditionalStatements()
        {
            /*conditional Statements are used for a certain block of
             * code needs to excuted when some condition is fulfilled.
             * Conditional Statements
             * if
             * if-else
             * if-else-if-ladder
             * nested if
             * switch
             * nested switch
             * 
             */

            /* if (condition)
             * In C#, an if statement is used to execute a block
             * of code based on a specified condition. 
             * 
             * {
             *    code to be executed
             * }
             * 
             * if else(condtion)
             * The if state evaluates the code if the condiction is true,
             * otherwise else statement tells the code what to do
             * if (condition)
             * {
             * code if condition is true
             * }
             * else
             * {
             * code if condition is false
             * }
             * 
             * 
             * 
             * if-else-if ladder
             * if (condition)
             * {
             * code to be excuted if condition1 is true
             * }
             * else if
             * {
             *  code to be excuted if condition2 is true
             *  }
             *  else
             *  {
             *  code to be excuted if all condictions all flase
             *  }
             *  
             *  
             *  Nested if
             *  /
               
              
             *  Switch(expression)
             *  {
             *  case value 1:statement sequence
             *  break;
             *  case value 2:statement sequence
             *  break;
             *  case value N:statement sequence
             *  break;
             *  default:default statement sequance
             *  
             *  
             *  
             *  LOOPING / ITERATION STATEMENTS
             *  While
             *  do-while
             *  for
             *  nested for
             *  infnate for
             *  ************
             *  *JUMP STATEMENTS
             *  jump statements are uused to transfer control from one point to another point 
             *  Break
             *  Contuine
             *  Goto
             *  Return
             *  Throw
             *  Break:the break statements is ued to terminate the loop or statement
             *  in which is present
             *  break;
             */
            // if statements
            int a = 10;
            int b = 12;
            if (a > b)
            {
                Console.WriteLine("a is big");
            }
            else
            {
                Console.WriteLine("b is big");
            }

                //elseif
                int i = 10;
                int j = 12;
                int k = 56;

                if (i > j)
                {
                    //if(j<k)
                    Console.WriteLine("j  is big");
                }
                else if (j > k)
                {
                    Console.WriteLine("j is big");
                }
                else
                {
                    Console.WriteLine(" k is big");
                }
            
            //Switch
            Console.WriteLine("Enter the value");
            int H = Convert.ToInt32(Console.ReadLine());
            switch (H)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("enter vaild no");
                    break;
            }
            //nested switch
            switch (H)
            {
                case 1:
                    switch (a)
                    {
                        case 10:
                            Console.WriteLine("a is 10");
                            break;
                    }
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("enter vaild no");
                    break;
            }
        }

            static void whilestatments()
            {
                int i = 0;
                while (i < 3)
                {
                    Console.WriteLine("While{0}", i);
                i++;
                    
                }
            }
        /* do  while
         * int i = 0;
                while (i < 3)
                {
                    Console.WriteLine("While{0}", i);
                i++;
                 }while(i<0);
        */
        // for loop
        static void ForLoop()
        {
            
            for (int j = 0; j < 9; j++) 
            {
                Console.WriteLine("foorloop");
            }
        }
          static void nestedloop()
        {
            int[,] d = new int[,] { { 1, 2 }, { 1, 2 } };
            Console.WriteLine("Array values are");
            for (int j = 0; j < 2; j++)
            {
                for(int k=0; k<2; k++)
                    Console.WriteLine(d[j,k]);
            }
        }

        static void infinatenestedloop()
        {
            int[,] d = new int[,] { { 1, 2 }, { 1, 2 } };
            Console.WriteLine("Array values are");
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                    Console.WriteLine(d[j, k]);
            }
            for (; ; )
                Console.WriteLine("Error"); //alt f4 to close
        }
        static void GoToO()
        {
        A:
            Console.WriteLine("hi");

            int f = 1;
            if(f == 1)
            {
                goto A;
            }
        }




    } 
}

      

        



























































