using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Bao Nguyen", 18));
            students.Add(new Student(2, "An Nguyen", 15));
            students.Add(new Student(3, "Tan Tai", 16));
            students.Add(new Student(4, "Anh Phan", 17));
            students.Add(new Student(5, "Bao Anh", 16));
            
            //In ra danh sach hoc sinh
            Console.WriteLine("Danh sach hoc sinh: ");
            foreach (var student in students) {
                student.ShowThongTin();
            }

            //In ra danh sach hoc sinh tu 15 - 18
            Console.WriteLine("");
            Console.WriteLine("Danh sach hoc sinh tu 15 - 18 tuoi:");
            var findStudent = students.Where(s => s.Tuoi > 15 && s.Tuoi < 18).ToList();
            foreach (var student in findStudent)
            {
                student.ShowThongTin();
            }

            //In ra hoc sinh co tu bat dau bang A
            Console.WriteLine("");
            Console.WriteLine("Nhung hoc sinh bat dau bang chu A:");
            var studentSrartA = students.Where(s => s.Ten.StartsWith("A")).ToList();
            foreach(var  student in studentSrartA)
            {
                student.ShowThongTin();
            }

            //Tong tuoi cua tat ca hoc sinh trong danh sach
            Console.WriteLine("");
            int sumAge = students.Sum(s => s.Tuoi);
            Console.WriteLine($"Tong tuoi cua tat ca hoc sinh: {sumAge}");


            //In ra hoc sinh co tuoi lon nhat
            Console.WriteLine("");
            Console.WriteLine("Hoc sinh co tuoi lon nhat: ");
            int maxAge = students.Max(s => s.Tuoi);
            var maxAgeStudent = students.Where(s => s.Tuoi == maxAge);
            foreach(var student in maxAgeStudent)
            {
                student.ShowThongTin();
            }

            //Danh sach hoc sinh tang dan
            Console.WriteLine("");
            Console.WriteLine("Danh sach hoc sinh theo tuoi tang dan: ");
            var ageIncreasing = students.OrderBy(s => s.Tuoi).ToList();
            foreach(var student in ageIncreasing)
            {
                student.ShowThongTin();
            }
            Console.ReadLine();
        }
    }
}
