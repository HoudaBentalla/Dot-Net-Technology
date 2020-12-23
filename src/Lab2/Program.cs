using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>() ;

            Console.WriteLine("Please enter number of student");
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i<count; i++)
            {
                Console.WriteLine("please enter student no {0}", i+1);
                var student = new Student();
                Console.WriteLine("Name: ");
                student.FirstName = Console.ReadLine();
                Console.WriteLine("LastName: ");
                student.LastName = Console.ReadLine();
                Console.WriteLine("PhoneNumber: ");
                student.PhoneNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Email: ");
                student.Email = Console.ReadLine();

                students.Add(student);
            }

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}
