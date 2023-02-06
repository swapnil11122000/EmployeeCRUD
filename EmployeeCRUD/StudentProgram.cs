using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    public class StudentProgram
    {
        static void Main(string[] args)
        {
            StudentCRUD mystudent= new StudentCRUD();
            int v = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 Student List");
                Console.WriteLine("2 Add Student");
                Console.WriteLine("3 Update Student");
                Console.WriteLine("4 Delete Student");
                Console.WriteLine("5 Get Student By Id");

                Console.WriteLine("Enter Operation");
                int op2=Convert.ToInt32(Console.ReadLine());
                switch (op2)
                {
                    case 1:
                        Console.WriteLine("StudentID\tStudentName\tStudentMark");
                       
                        List<Student> s1 = mystudent.getStudents();
                        foreach (Student item in s1)
                        {
                            Console.WriteLine($"{ item.Stuid}\t\t{ item.Stuname}\t\t{ item.Stumark}");
                        }              
                        break;

                    case 2:
                        Student s2=new Student();
                        Console.WriteLine("Enter Student ID");
                        s2.Stuid= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name");
                        s2.Stuname=Console.ReadLine() ;
                        Console.WriteLine("Enter Marks");
                        s2.Stumark=Convert.ToInt32(Console.ReadLine());
                        mystudent.AddStudents(s2);
                        Console.WriteLine("Student Added");
                        break;


                    case 3:
                        Student s3= new Student();
                        Console.WriteLine("Enter Student ID");
                        s3.Stuid=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name");
                        s3.Stuname=Console.ReadLine() ;
                        Console.WriteLine("Enter Student Marks");
                        s3.Stumark=Convert.ToInt32(Console.ReadLine());
                        mystudent.UpdateStudent(s3);
                        Console.WriteLine("Student Updated");

                        break;

                    case 4:
                        Console.WriteLine("Enter Student ID");
                        int id = Convert.ToInt32(Console.ReadLine());
                        mystudent.DeleteStudent(id);
                        Console.WriteLine("Student Deleted");
                        break;
                    case 5:
                        Console.WriteLine("Enter Student ID");
                       
                        int id2=Convert.ToInt32(Console.ReadLine());
                        Student s8 = mystudent.GetStudentById(id2);
                        Console.WriteLine($"Id={s8.Stuid} Name={s8.Stuname},Marks={s8.Stumark} ");
                        break;
                    default:
                        Console.WriteLine("Wrong Option Selected");
                        break;
                }
                Console.WriteLine("Enter 1 to Continue");
                v=Convert.ToInt32(Console.ReadLine());
            }while(v==1);   
        }
    }
}
