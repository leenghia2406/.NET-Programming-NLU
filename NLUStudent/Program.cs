using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLUStudent
{
    internal class Program
    {
        List<NLUStudent> students = new List<NLUStudent>();
        void updateData(NLUStudent student_new)
        {
            NLUStudent student = students.Find(s => s.Id_student == student_new.Id_student);
            if (student != null )
            {
                student.Full_name = student_new.Full_name;
                student.Phone = student_new.Phone;
                student.Email = student_new.Email;
                student.Age = student_new.Age;
                student.Nlu_class = student_new.Nlu_class;
                Console.WriteLine("Cap nhat thanh cong thong tin sinh vien: " + student_new.Full_name);
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien");
            }
        }
        void deleteData(int id_student)
        {
            NLUStudent student = students.Find(s => s.Id_student == id_student);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Xoa thanh cong sinh vien: " + student.Full_name);
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien");
            }
        }
        void insertData(NLUStudent student_new)
        {
            students.Add(student_new);
            Console.WriteLine("Them sinh vien thanh cong");
        }
        void printData()
        {
            if(students.Count == 0)
            {
                Console.WriteLine("Danh sach sinh vien trong");
                return;
            }
            foreach (NLUStudent student in students)
            {
                Console.WriteLine("ID: " + student.Id_student + ", Ten: " + student.Full_name +
                    " ,Tuoi: " + student.Age + " ,Email: " + student.Email + " ,Dien thoai: " + student.Phone
                    + " ,Lop: "+ student.Nlu_class);
            }
        }
        static void Main(string[] args)
        {

        }

    }
}

