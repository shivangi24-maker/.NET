using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    delegate void CalculatorHandleDelegate(int number1, int number2);
    class Calculate
    {
        public static int number1 { get; set; }
        public static int number2 { get; set; }
        public static void Add(int n1, int n2)
        {
           Console.WriteLine(n1 + n2);

        }
        public static void Substract (int n1, int n2)
        {
            Console.WriteLine(n1 - n2);

        }
        public static void Divide(int n1, int n2)
        {
            Console.WriteLine(n1/n2);
          

        }
        public static void Multiply(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);

        }        
            static void Main(string[] args)
            {

               Console.Write("Enter First Number :");
               number1 = Convert.ToInt32(Console.ReadLine());
               Console.Write("Enter Second Number :");
               number2 = Convert.ToInt32(Console.ReadLine());
               
                CalculatorHandleDelegate obj = new CalculatorHandleDelegate(Add);
            obj += Substract;
            obj += Multiply;
            obj +=Divide;

            obj(number1, number2);
           
            Console.ReadKey(); 
            }
        }
    }

