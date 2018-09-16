using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// //////////////
/// </summary>

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudent = new List<Student>();
           
            Student student1 = new Student
            {
                Name = "A",
                Surname = "A",
                Group = 2,
             };
            student1.Set("one", 5);
            student1.Set("two", 2);
            student1.Set("three", 8);
            
            Student student2 = new Student
            {
                Name = "B",
                Surname = "B",
                Group = 2,
            };
            student2.Set("one", 4);
            student2.Set("two", 8);
            student2.Set("three", 1);
            
            Student student3 = new Student
            {
                Name = "C",
                Surname = "C",
                Group = 2,
            };

            student3.Set("one", 10);
            student3.Set("two", 10);
            student3.Set("three", 10);

            Student student4 = new Student
            {
                Name = "D",
                Surname = "D",
                Group = 2,
            };
            student4.Set("one", 5);
            student4.Set("two", 2);
            student4.Set("three", 3);



            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);

            float Sum_Subject = 0;
            int Person = listStudent.Count;
            foreach (var list in listStudent)
            {
                Sum_Subject += list.GetSubjectSum("one");
            }
            Console.WriteLine("Average mark of one: {0}", Sum_Subject / Person);
           
                   
            float Sum_Group = 0;
            foreach (var list in listStudent)
            {
                if (list.Group.Equals(2))
                    Sum_Group += list.GetSubjectSum();
            }
            Console.WriteLine("Average mark on the Group 2: {0}", Sum_Group / Person);
        }
    }
}
