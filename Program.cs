using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string city = "Kolhapur";
            //  int year = 2022;
            //char gender = 'M' ;
            // float salary1 = 25000.56f;
            // double salary2 = 50000.78;
            // Console.WriteLine("My current city is "+city+" year is " +year);
            //  Console.WriteLine("My salary in float is {0}", salary1);
            // Console.WriteLine($"My Salary in double is {salary2}");

            //Console.WriteLine("Enter two Numbers ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int addition = n1 + n2;
            //Console.WriteLine($" Addition is {addition}");




            //int num = 14;

            //if (num%2==0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            //   char A = 'd';
            //   if(A=='a' || A=='e'|| A=='i' || A=='o'|| A=='u')
            //{
            //       Console.WriteLine("It is a vowel");

            //   }
            //   else 
            //   {
            //       Console.WriteLine("It is consonent");
            //   }


            //Console.WriteLine($"Enter the Numbers");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int n3 = Convert.ToInt32(Console.ReadLine());


            //if (n1 > n2)
            //{
            //    if (n1 > n3)
            //    {
            //        Console.WriteLine($"{n1} is greatest number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{n3} is greatest number");
            //    }
            //}
            //else
            //{
            //    if (n2 > n3)
            //    {
            //        Console.WriteLine($"{n2} is greatest number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{n3} is greatest number");
            //    }
            //}

            //if(n1>n2 && n1 > n3)
            //{
            //    Console.WriteLine($"{n1} is greast numer");
            //}
            //if(n2>n1 && n2 > n3)
            //{
            //    Console.WriteLine($"{n2} is greast numer");
            //}
            //if(n3>n1 && n3 > n2)
            //{
            //    Console.WriteLine($"{n3} is greast numer");
            //}




            Console.WriteLine($"Enter the Numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. for Add");
            Console.WriteLine("2. for Sub");
            Console.WriteLine("3. for Multi");
            Console.WriteLine("4. for Div");
            Console.WriteLine("5. for Mod");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = n1 + n2;
            int sub = n1 - n2;
            int multi = n1 * n2;
            int div = n1 / n2;
            int Mod = n1 % n2;
            switch (num)
            {
                case 1:
                    Console.WriteLine($"You choose add {sum}");
                    break;
                case 2:
                    Console.WriteLine($"You choose Sub {sub}");
                    break;
                case 3:
                    Console.WriteLine($"You choose Multi {multi}");
                    break;
               case  4:
                    Console.WriteLine($"You choose Division {div}");
                    break;
               case 5:
                    Console.WriteLine($"You choose Mod {Mod}");
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;


            }





        }
    }
}
