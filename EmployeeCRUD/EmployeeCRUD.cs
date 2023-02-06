using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD
{
    public class EmployeeCRUD
    {
        public List<Employee> employees;//created list
        public EmployeeCRUD() //constructor
        {
            employees = new List<Employee>()
            {
            new Employee { Id=101,Name="Raj",Salary=4000},
            new Employee{Id=102,Name="Neha",Salary=50000},
            };
        }

       public List<Employee> List()
        {
            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id==employee.Id)
                {
                    employees[i].Name = employee.Name;
                    employees[i].Salary= employee.Salary;
                    break;
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id==id)
                {
                    employees.Remove(employees[i]);
                    break;
                }

            }
        }

        public Employee GetEmployeeById(int id2)
        {
            Employee e4=new Employee();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id==id2)
                {
                    e4 = employees[i];
                }
            }
            return e4;
        }


    }
}
