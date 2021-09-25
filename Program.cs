using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public interface IOrder
    {
        void Confirm();
    }
    public interface ICancellable
    {
        void Cancle();
    }
    class Order:IOrder,ICancellable
    {
        int ID { get; set; }
        string Status { get; set; }
        private string customerName1;
        public string CustomerName1
        {
            set { customerName1 = value; }
            get { return customerName1; }
        }
        private int OrderAmount1;
        public int orderAmount1
        {
            set { OrderAmount1 = value; }
            get { return OrderAmount1; }
        }
        string CustomerName { get; set; }
        int OrderAmount { get; set; }
        public string OrderStatus;
        public void Confirm()
        {
            OrderStatus = "Confirmed";
            Console.WriteLine("Order Status: " + OrderStatus);
            Console.WriteLine("Thank you!!");
        }
        public void Cancle()
        {
            OrderStatus = "Confirmed";
            Console.WriteLine("Order Status: " + OrderStatus);
            Console.WriteLine("Thank you!!");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer name");
            string CustomerName1 = Console.ReadLine();

            Console.WriteLine("Enter Amount");
            int OrderAmount1 = Convert.ToInt32(Console.ReadLine());

            DateTime OrderDate = DateTime.Today;

            Console.WriteLine("Enter your choice what you want to do");
            Console.WriteLine("1.Confirm");
            Console.WriteLine("2.Cancle");
            int Choice = Convert.ToInt32(Console.ReadLine());
            Order Obj = new Order();
            Obj.CustomerName1 = CustomerName1;
            Obj.orderAmount1 = OrderAmount1;
            Console.WriteLine("Your order details......");
            Console.WriteLine("Your Name:" + Obj.CustomerName1);
            Console.WriteLine("Your order amount"+ Obj.orderAmount1);
            Console.WriteLine("Your order Date:"+OrderDate);
            switch (Choice)
            {
                case 1:
                    Obj.Confirm();
                    break;

                case 2:
                    Obj.Cancle();
                    break;

                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
