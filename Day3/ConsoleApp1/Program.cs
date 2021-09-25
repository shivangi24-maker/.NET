using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
        class Employee : IComparable<Employee>
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }

            public int CompareTo(Employee other)
            {
                //return 0 when current == other
                //return 1 when current > other
                //return -1 when current < other
                //if (this.ID == other.ID)
                //    return 0;
                //else if (this.ID > other.ID)
                //    return 1;
                //else
                //    return -1;
                return this.ID.CompareTo(other.ID);
            }

            public override string ToString()
            {
                return $"{this.ID}\t\t{this.Name}\t\t{this.Salary}";
            }
        }
        class Program
        {
            static List<Employee> EmployeesList;
            static void Main(string[] args)
            {
                var employee = new Employee();
                employee.ID = 105;
                employee.Name = "Jojo";
                employee.Salary = 5000;
                //var EmployeesList = new List<Employee>();
                EmployeesList = new List<Employee>()
            {                                           //Collection initializer
                employee,
                new Employee(){ID=102, Name="Sam", Salary=35000 }   //object initializer
            };
            int Choice = -1;
            while (true)
            {
                Console.WriteLine("\n1.Add employee");
                Console.WriteLine("2.List all employees");
                Console.WriteLine("3.Search employee by Id");
                Console.WriteLine("4.Update employee");
                Console.WriteLine("5.Delete employee");
                Console.WriteLine("6.Sort employees");
                Console.WriteLine("7.Exit");
                Console.WriteLine("\n\nYour choice:");
                Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        AddNewEmployee();
                        break;
                    case 2:
                        DisplayEmployees();
                        break;
                    case 3:
                        SearchEmployee();
                        break;
                    case 4:
                        UpdateEmployee();
                        break;
                    case 5:
                        RemoveEmployee();
                        break;
                    case 6:
                        EmployeesList.Sort();
                        DisplayEmployees();
                        break;
                    case 7: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
        private static void RemoveEmployee()
        {
            int IDToSearch = -1;
            Console.WriteLine("Enter the id to search");
            IDToSearch = Convert.ToInt32(Console.ReadLine());

            bool IsFound = false;
            foreach (var emp in EmployeesList)
            {
                if (emp.ID == IDToSearch)
                {
                    Console.WriteLine("Employee found");
                    Console.WriteLine(emp.ToString());
                    EmployeesList.Remove(emp);
                    IsFound = true;
                    break;
                }
            }
            if (!IsFound)
                Console.WriteLine("Employee not found for Id = {0}", IDToSearch);
        }
        private static void UpdateEmployee()
        {
            int IDToUpdate = -1;
            Console.WriteLine("Enter the id to search");
            IDToUpdate = Convert.ToInt32(Console.ReadLine());

            bool IsFound = false;
            foreach (var emp in EmployeesList)
            {
                if (emp.ID == IDToUpdate)
                {
                    Console.WriteLine("Employee found");
                    Console.WriteLine(emp.ToString());
                    Console.WriteLine("Enter new name");
                    emp.Name = Console.ReadLine();

                    Console.WriteLine("Enter new salary");
                    emp.Salary = Convert.ToDouble(Console.ReadLine());
                    IsFound = true;
                    break;
                }
            }
            if (!IsFound)
                Console.WriteLine("Employee not found for Id = {0}", IDToUpdate);
        }
        private static void SearchEmployee()
        {
            //int IDToSearch = -1;
            //Console.WriteLine("Enter the id to search");
            //IDToSearch = Convert.ToInt32(Console.ReadLine());

            //bool IsFound = false;
            //foreach (var emp in EmployeesList)
            //{
            //    if (emp.ID == IDToSearch)
            //    {
            //        Console.WriteLine("Employee found");
            //        Console.WriteLine(emp.ToString());
            //        IsFound = true;
            //        break;
            //    }
            //}
            //if (!IsFound)
            //    Console.WriteLine("Employee not found for Id = {0}", IDToSearch);

            Console.WriteLine("Enter id to search");
            int id = Convert.ToInt32(Console.ReadLine());

            var Index = EmployeesList.BinarySearch(new Employee { ID = id });
            if (Index >= 0)
            {
                Console.WriteLine("Employee found");
                Console.WriteLine(EmployeesList[Index]);
            }
            else
            {
                Console.WriteLine("Employee not found");
            }

        }
        private static void DisplayEmployees()
        {
            Console.WriteLine("ID\t\tName\t\tSalary");
            foreach (var emp in EmployeesList)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        private static void AddNewEmployee()
        {
            var EmployeeToAdd = new Employee();
            Console.WriteLine("Enter id");
            EmployeeToAdd.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            EmployeeToAdd.Name = Console.ReadLine();

            Console.WriteLine("Enter salary");
            EmployeeToAdd.Salary = Convert.ToDouble(Console.ReadLine());

            EmployeesList.Add(EmployeeToAdd);
        }
    }
}
