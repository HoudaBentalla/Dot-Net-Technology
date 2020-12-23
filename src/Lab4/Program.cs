using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        public static void Main(string[] arg)
        {
            var student = new StudentExtended();
            Console.WriteLine("Name: ");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("LastName: ");
            student.LastName = Console.ReadLine();
            Console.WriteLine("PhoneNumber: ");
            student.PhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Email: ");
            student.Email = Console.ReadLine();
            Console.WriteLine("Please Enter your Birthdate (exp 2020, 12,30)");
            DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
            student.BirthDate = inputtedDate;
            Console.WriteLine("Please Enter Date of your admission(exp 2018, 09,30)");
            DateTime inputtedDate2 = DateTime.Parse(Console.ReadLine());
            student.Admission = inputtedDate2;
            Console.WriteLine("Plese Enter your faculty name");
            student.Faculty = Console.ReadLine();
            Console.WriteLine("Plese Enter your specialty number");
            student.Specialty_number = Console.ReadLine();
            Console.WriteLine(student.ToString());
            Console.ReadKey();
        }
       
    }

    public class StudentExtended:Student
    {
        public DateTime BirthDate { get; set; }
        public DateTime Admission { get; set; }
        public string Faculty { get; set; }
        public string Specialty_number { get; set; }
        public int Age
        {
            get
            {
                var age = DateTime.Today.Year - BirthDate.Year;
                if (BirthDate.Date > DateTime.Today.AddYears(-age)) age--;
                return age;
            }
        }
        public int CourseNo
        {
            get
            {
                var courseNo = DateTime.Today.Year - Admission.Year;
                if (DateTime.Today.Month > 8) courseNo++;
                return courseNo;
            }
        }
        public int SemesterNO
        {
            get
            {
                var semesterNo = CourseNo * 2;
                if (DateTime.Today.Month > 8 || DateTime.Today.Month < 2) semesterNo--;
                return semesterNo;
            }
        }

        public string GroupNo
        {
            get
            {
                return $"{Faculty}{Specialty_number}{Admission.ToString("yy")}";
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} ");
            sb.AppendLine($"Lastname: {LastName} ");
            sb.AppendLine($"Phone: {PhoneNumber} ");
            sb.AppendLine($"Email: {Email} ");
            sb.AppendLine($"BirthDate: {BirthDate.ToString("yyyy,MM,dd")} ");
            sb.AppendLine($"Date of Admission: {Admission.ToString("yyyy,MM,dd")} ");
            sb.AppendLine($"Faculty:{Faculty} ");
            sb.AppendLine($"Specialty Number: {Specialty_number} ");
            sb.AppendLine($"Age: {Age} CourseNo:{CourseNo} ");
            sb.AppendLine($"CourseNo:{CourseNo} ");
            sb.AppendLine($"SemesterNo:{SemesterNO} ");
            sb.AppendLine($"GroupeNo: {GroupNo}");
            return sb.ToString();

            //return $"Name: {FirstName} Lastname: {LastName} Phone: {PhoneNumber} Email: {Email} BirthDate: {BirthDate.ToString("yyyy,MM,dd")} Date of Admission: {Admition.ToString("yyyy,MM,dd")} Faculty:{Faculty} Specialty Number: {Specialty_number} Age: {Age} CourseNo:{CourseNo} SemesterNo:{SemesterNO} GroupeNo: {GroupNo}  ";

        }


    }
}