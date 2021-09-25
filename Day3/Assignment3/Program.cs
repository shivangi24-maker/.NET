using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    class Program
    {
        static Dictionary<string, string> Information = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter your choice what you want to do");
                Console.WriteLine("1.Add details");
                Console.WriteLine("2.remove distict name on base of RTO code");
                Console.WriteLine("3.List of all RTO and distric name");

                 int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        AddDetails();
                        Console.WriteLine("Data entered successfully");
                        ListDetails();
                        break;

                    case 2:
                        RemoveDetails();
                        //ListDetails();
                        break;

                    case 3:
                        ListDetails();
                        break;
                    default:
                        Console.WriteLine("Enter right choice");
                        break;

                }
            }
        }
        private static void AddDetails()
        {
            Console.WriteLine("Enter RTO code");
            string RtoCode = Console.ReadLine();

            Console.WriteLine("Enter district name");
            string DistrictName = Console.ReadLine();

            Information.Add(RtoCode, DistrictName);
        }
        private static void ListDetails()
        {
            foreach (var key in Information.Keys)
            {
                Console.WriteLine($"RTO Code={key}, District={Information[key]}");
            }
        }
        private static void RemoveDetails()
        {
            Console.WriteLine("Enter RTO code for delete");
            string RtoCode = Console.ReadLine();
            Boolean Found = false;
            foreach (var key in Information.Keys)
            {
                if (key == RtoCode)
                {
                    //Information.Remove(RtoCode);
                    Console.WriteLine("Found");
                    Found = true;
                    break;
                }
            }
            if(!Found)
            {
                Console.WriteLine("Data not found");
               
                

            }

        }
    }
}
