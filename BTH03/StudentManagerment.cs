using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH03
{
    internal class StudentManagerment
    {
        List<Student> students = new List<Student>();
        public void runApp()
        {
            int choose;
            do
            {
                Console.WriteLine("Lap trinh .NET thuc hanh Student Managerment");
                Console.WriteLine("********************************************");
                Console.WriteLine("1. Them Sinh Vien");
                Console.WriteLine("2. Cap nhat thong tin sinh vien boi ID");
                Console.WriteLine("3. Xoa sinh vien boi ID");
                Console.WriteLine("4. Tim kiem sinh vien theo ten");
                Console.WriteLine("5. Sap xep sinh vien theo diem trung binh");
                Console.WriteLine("6. Sap xep sinh vien theo ten");
                Console.WriteLine("7. Sap xep sinh vien theo ID");
                Console.WriteLine("8. Hien thi danh sach sinh vien");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("********************************************");
                Console.WriteLine("Nhap tuy chon");

                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        addStudent();
                        break;
                    case 2:
                        updateByID();
                        break;
                    case 3:
                        deleteByID();
                        break;
                    case 4:
                        findStudentByName();
                        break;
                    case 5:
                        sortByAvgScore();
                        break;
                    case 6:
                        sortByName();
                        break;
                    case 7:
                        sortByID();
                        break;
                    case 8:
                        printStudentList();
                        break;
                }

            } while (choose != 0);
        }
        public void addStudent()
        {
            Student student = new Student();
            Console.WriteLine("Nhap ID sinh vien");
            int id = int.Parse(Console.ReadLine());
            student.ID = id;
            Console.WriteLine("Nhap ten sinh vien: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh sinh vien: ");
            student.Sex = Console.ReadLine();
            Console.WriteLine("Nhap tuoi sinh vien: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem toan: ");
            student.DiemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            student.DiemLy = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa: ");
            student.DiemHoa = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem trung binh");
            student.DiemTB = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap hoc luc");
            student.HocLuc = Console.ReadLine();
            Console.WriteLine("Them sinh vien thanh cong");
            students.Add(student);
        }
        private void updateByID()
        {
            Console.WriteLine("Nhap ID sinh vien: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten sinh vien: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            string sex = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem toan: ");
            double diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            double diemLy = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa");
            double diemHoa = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem trung binh: ");
            double diemTB = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap hoc luc: ");
            string hocLuc = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.ID == id)
                {
                    student.Name = name;
                    student.Sex = sex;
                    student.Age = age;
                    student.DiemToan = diemToan;
                    student.DiemLy = diemLy;
                    student.DiemHoa = diemHoa;
                    student.DiemTB = diemTB;
                    student.HocLuc = hocLuc;
                    Console.WriteLine("Cap nhat thong tin thanh cong");
                    break;
                }
            }
        }
        private void deleteByID()
        {
            Console.WriteLine("Nhap ID sinh vien");
            int id = int.Parse(Console.ReadLine());
            foreach (Student student in students)
            {
                if (student.ID == id)
                {
                    students.Remove(student);
                    Console.WriteLine("Xoa thanh cong");
                }
            }
        }
        private void findStudentByName()
        {
            Console.WriteLine("Nhap ten sinh vien can tim: ");
            string name = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.Name == name)
                {
                    Console.WriteLine("Ten sinh vien: " + student.Name);
                    Console.WriteLine("ID: " + student.ID);
                    Console.WriteLine("Gioi tinh: " + student.Sex);
                    Console.WriteLine("Diem toan: " + student.DiemToan);
                    Console.WriteLine("Diem ly: " + student.DiemLy);
                    Console.WriteLine("Diem hoa: " + student.DiemHoa);
                    Console.WriteLine("Diem trung binh" + student.DiemTB);
                    Console.WriteLine("Hoc Luc: " + student.HocLuc);
                }
            }
        }
        private void sortByID()
        {
            students.Sort((student1, student2) => student1.ID.CompareTo(student2.ID));
            Console.WriteLine("Danh sach sinh vien sau khi sap xep theo ID:");
            printStudentList();
        }

        private void sortByName()
        {
            students.Sort((student1, student2) => student1.Name.CompareTo(student2.Name));
            Console.WriteLine("Danh sach sinh vien sau khi sap xep theo ten:");
            printStudentList();
        }

        private void sortByAvgScore()
        {
            students.Sort((student1, student2) => student1.DiemTB.CompareTo(student2.DiemTB));
            Console.WriteLine("Danh sach sinh vien sau khi sap xep theo diem TB:");
            printStudentList();
        }
        public void printStudentList()
        {
            foreach (Student st in students)
            {
                Console.Write(st.Name + ", ");
                Console.WriteLine(st.Sex + ", ");
                Console.WriteLine(st.Age + ", ");
                Console.WriteLine(st.DiemToan + ", ");
                Console.WriteLine(st.DiemLy + ", ");
                Console.WriteLine(st.DiemHoa + ", ");
                Console.WriteLine(st.DiemTB + ", ");
                Console.WriteLine(st.HocLuc);
            }
        }

    }
}
