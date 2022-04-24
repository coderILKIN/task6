using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
    class Student
    {
        private int _point;
        private static int id;
        public int Id { get;}

        public string Fullname { get; set; }

        public int Point { 
            get 
            {
                return _point;
            } 
            set
            {
                if (value<0 && value>=100)
                {
                    _point = value;
                }
            }
        }

        public Student(string fullname,int point)
        {
            Id = ++id;
            Fullname = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullnam: {Fullname}, Point: {Point}");
        }
    }
}
