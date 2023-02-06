using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeCRUD myemployee = new EmployeeCRUD();
            int c = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 Employee List");
                Console.WriteLine("2 Add Employee");
                Console.WriteLine("3 Update Employee");
                Console.WriteLine("4 Delete Employee");
                Console.WriteLine("5 Get Employee");
             

                Console.WriteLine("Select Operation");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        List<Employee> emps = myemployee.List();
                        Console.WriteLine("ID\tName\tSalary");
                        foreach (Employee item in emps)
                        {
                            Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Salary}");
                        }
                        break;
                    case 2:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter ID");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        e1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());
                        myemployee.AddEmployee(e1);
                        Console.WriteLine("Employee Added");
                        break;
                    case 3:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter ID");
                        e2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        e2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        e2.Salary = Convert.ToInt32(Console.ReadLine());
                        myemployee.UpdateEmployee(e2);
                        Console.WriteLine("Employee Updated");
                        break;

                    case 4:
                        Console.WriteLine("Enter Id ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        myemployee.DeleteEmployee(id);
                        Console.WriteLine("Employee deleted ");

                        break;

                    case 5:
                     
                        Console.WriteLine("Enter ID");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Employee emp3 = myemployee.GetEmployeeById(id2);
                        Console.WriteLine($"ID={emp3.Id} Name={emp3.Name} Salary={emp3.Salary}");
                        break;

                    default:
                        Console.WriteLine("Erong option selected");
                        break;

                   
                }
                Console.WriteLine("select 1 to continue");
                c = Convert.ToInt32(Console.ReadLine());

            } while (c==1);




        }
    }
}
