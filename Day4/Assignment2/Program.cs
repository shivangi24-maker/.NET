using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }
        public DateTime Createon { get; set; }
        public Product()
        {

        }

        public Product(int id, string name, int price, string company, DateTime createon)
        {
            this.ID = id;
            Console.Write(this.ID);
            this.Name = name;
            Console.Write("\t" + this.Name);
            this.Price = price;
            Console.Write("\t" + this.Price);
            this.Company = company;
            Console.Write("\t" + this.Company);
            this.Createon = createon;
            Console.Write("\t" + this.Createon);
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Id={this.ID} ,Name={this.Name},Price={this.Price},Company={this.Company},Createon={this.Createon}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var Data = GetEmployee();
            var Query1 = from Obj in Data
                         orderby Obj.Name ascending
                         select Obj;

            Console.WriteLine("Assending by name:");
            foreach (var Output in Query1)
            {
                Console.WriteLine(Output);
            }

            var Query2 = from Obj in Data
                         where Obj.Price > 999 && Obj.Price < 2001
                         select Obj;
            Console.WriteLine("Price between 1000 and 2000:");
            foreach (var Output in Query2)
            {
                Console.WriteLine(Output);
            }

            var Query3 = from Obj in Data
                         where Obj.Createon.Year == 2021
                         select Obj;
            Console.WriteLine("Select who have createon year 2021:");
            foreach (var Output in Query3)
            {
                Console.WriteLine(Output);
            }

            Console.ReadKey();
        }
        static List<Product> GetEmployee()
        {
            var Employees = new List<Product>()
            {
                new Product(101, "Pendrive", 1100, "Abc", new DateTime(2021, 01, 10)),
                new Product(102, "Wireless Keyboard", 3000, "Hardip", new DateTime(2021, 12, 10)),
                new Product(103, "Wireless Mouse", 1500, "Mayur", new DateTime(2015, 05, 10)),
                new Product(104, "Formal Shoes", 3000, "Yuvraj", new DateTime(2021, 12, 10)),
                new Product(105, "Formal Shirt", 2200, "Piyush",new DateTime(2015, 01, 10))
            };
            return Employees;
        }


    }
}