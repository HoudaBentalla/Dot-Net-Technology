using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var student = new Student();

            Console.WriteLine("Name: ");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("LastName: ");
            student.LastName = Console.ReadLine();
            Console.WriteLine("PhoneNumber: ");
            student.PhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Email: ");
            student.Email = Console.ReadLine();
            Console.WriteLine($"Name: {student.FirstName} Lastname: {student.LastName} Phone: {student.PhoneNumber} Email: {student.Email}");

            Console.ReadKey();
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName}\tLastname: {LastName} \tPhone: {PhoneNumber}\tEmail: {Email}";
        }
    }
}
