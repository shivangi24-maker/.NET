using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string OrderDate { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        protected double orderAmount;
        public double OrderAmount
        { 
            get { return OrderAmount; }        
        }
        public double CalculateOrderAmount()
        {
            orderAmount = Price * Quantity;
            return orderAmount;
        }

            public  void PrintOrderDetails()
          
        {
            Console.WriteLine("\n******** Order Details********\n");
            Console.WriteLine("OrderId : " +OrderId);
            Console.WriteLine("CustomerName " + CustomerName);
            Console.WriteLine("OrderDate " + OrderDate);
            Console.WriteLine("ProductName " + ProductName);
            Console.WriteLine("Pice " + Price);
            Console.WriteLine("Quantity " + Quantity);
            Console.WriteLine("OrderAmount " + OrderAmount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Order obj = new Order();

            Console.WriteLine("Enter OrderId");
            obj.OrderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name");
            obj.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter OrderDate");
            obj.OrderDate = Console.ReadLine();

            Console.WriteLine("Product Name");
            obj.ProductName = Console.ReadLine();

            Console.WriteLine("Enter Price");
            obj.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Quantity");
            obj.Quantity = Convert.ToInt32(Console.ReadLine());

            obj.CalculateOrderAmount();

            obj.PrintOrderDetails();

            Console.ReadKey();

        }
    }
}
