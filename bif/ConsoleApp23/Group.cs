using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
    class Group
    {
        private string _groupno;
        private byte _studentlimit;
        public string GroupNo { 
            get
            {
                return _groupno;
            } 
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupno = value;
                }
            } 
        }

        public Group(string groupno,byte studentlimit)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }

        private Student[] Students = new Student[0];

        public byte StudentLimit {
            get 
            {
                return _studentlimit;
            }
            set 
            {
                if (value>=5 && value<=18)
                {
                    _studentlimit = value;
                }
            } 
        }


        public static bool CheckGroupNo(string password)
        {
            bool Hasdigit = false;
            bool HasUpper = false;

            if (!string.IsNullOrEmpty(password))
            {
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        Hasdigit = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        HasUpper = true;
                    }
                    if (Hasdigit && HasUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

            public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void GetStudent(int ? id)
        {
            if (id==null)
            {
                foreach (var item in Students)
                {
                    if (item.Id == id)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            Console.WriteLine($"{id} null ola bilmez");
        }


        public Student[] GetAllStudents()
        {
            return Students;
        }

    }
}
