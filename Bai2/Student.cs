using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Student
    {
        private int mshs;
        private string ten;
        private int tuoi;

        public Student(int mshs, string ten, int tuoi)
        {
            Mshs = mshs;
            Ten = ten;
            Tuoi = tuoi;
        }

        public int Mshs { get; set; }

        public string Ten { get; set; }

        public int Tuoi { get; set; }

        public void ShowThongTin()
        {
            Console.WriteLine("Mshs: " + Mshs);
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Tuoi: " + Tuoi);
        }


    }
}
