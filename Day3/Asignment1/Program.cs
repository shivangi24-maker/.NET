using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment1
{
    class XyzBankLtd
    {
        private int AccountNo;
        public int accountNo
        {
            get { return AccountNo; }
            set { AccountNo = value; }
        }
        private int CustomerName;
        public int customerName
        {
            get { return CustomerName; }
            set { CustomerName = value; }

        }
        private int Balance = 2000;
        public int balance
        {
            get { return Balance; ; }
  
        }
        public void WithDraw(int a)
        {
            if (a >= Balance)
            {
                throw new ArgumentException("Insufficient Balance.....");
            }
            else
            {
                Balance -= a;
                Console.WriteLine("your balance is :" + Balance);
            }
        }
        public void Deposit(int a)
        {
            if (a <=0)
            {
                throw new ArgumentException("Invalid value of amount .....");
            }
            else
            {
                Balance += a;
                Console.WriteLine("Your balance is :" + Balance);
            }
        }
        static void Main(string[] args)
        {

            Boolean Entry = false;
            int FirstEntry = 1;
            while (FirstEntry==1)
            {
                try
                {
                    Console.WriteLine("Enter your acount number");
                    int AcountNo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your name");
                    string CustomerName = Console.ReadLine();
                    FirstEntry = 0;
                    Entry = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Enter valid details");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter valid details");
                }
            }
            var Obj = new XyzBankLtd();
            while (Entry)
            {
                Console.WriteLine("Enter your choice what you want to do");
                Console.WriteLine("1.Withdraw");
                Console.WriteLine("2.Deposit");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch(Choice)
                {
                    case 1:

                        try
                        {
                            Console.WriteLine("Enter amount to perform operation");
                            int Amount = Convert.ToInt32(Console.ReadLine());
                            Obj.WithDraw(Amount);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        break;
                        case 2:

                        try
                        {
                            Console.WriteLine("Enter amount to perform operation");
                            int Amount = Convert.ToInt32(Console.ReadLine());
                            Obj.Deposit(Amount);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Please enter value more than 0");
                        }
                        break;

                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;

                        



                }

            }
            Console.ReadKey();
            }
        }
    }

