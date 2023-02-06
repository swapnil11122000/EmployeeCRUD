using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    public class StudentCRUD
    {
        List<Student> students;
        public StudentCRUD()
        {
            students = new List<Student>()
            {
                new Student() {Stuid=11,Stuname="swapnil",Stumark=98},
                new Student() {Stuid=12,Stuname="raj",Stumark=97},
            };
        }

        public List<Student> getStudents()
        {
            return students;
        }

        public void AddStudents(Student student)
        {
            students.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Stuid==student.Stuid)
                {
                    students[i].Stuname = student.Stuname;
                    students[i].Stumark = student.Stumark;
                    break;
                }
            }
        }

        public void DeleteStudent(int id)
        {
            
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Stuid==id)
                {
                    students.Remove(students[i]);
                    break;
                }
            }
        }


        public Student GetStudentById(int id2)
        {
            Student s5=new Student();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Stuid==id2)
                
                    s5= students[i];
                

            }
            return s5 ;
        }






    }
}
