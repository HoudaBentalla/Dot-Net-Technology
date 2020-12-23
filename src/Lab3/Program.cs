using Lab1;
using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello for input new students from Console input 1 or for get students from File input 2");
            var students = new List<Student>();
            var command = Console.ReadLine();
            if (command == "1")

            {

                Console.WriteLine("Please enter number of student");
                var count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("please enter student no {0}", i + 1);
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

                string[] lines = new string[students.Count];
                for (int i = 0; i < students.Count; i++)
                {
                    lines[i] = students[i].ToString();
                }

                System.IO.File.WriteAllLines("student.txt", lines);

            }

            else if (command == "2")
            {

                var input = System.IO.File.ReadAllLines("student.txt");
                foreach (var inp in input)
                {
                    var st = new Student();
                    var parts = inp.Split('\t');
                    st.FirstName = parts[0].Split(':')[1].Trim();
                    st.LastName = parts[1].Split(':')[1].Trim();
                    st.PhoneNumber = int.Parse(parts[2].Split(':')[1]);
                    st.Email = parts[3].Split(':')[1].Trim();
                    students.Add(st);
                }

            }


            // for all
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();

        }
    }
}
