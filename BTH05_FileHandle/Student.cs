using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH05_FileHandle
{
    internal class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public double AvgGrade { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Fullname}, Age: {Age}, AvgGrade: {AvgGrade}";
        }
    }
}
