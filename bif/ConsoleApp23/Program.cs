using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fullname please");
            string fullname = Console.ReadLine();

            int point;

            do
            {
                Console.WriteLine("Enter point please");
                point = Convert.ToInt32(Console.ReadLine());

            } while (point < 0 || point > 100);

            do
            {
                Console.WriteLine("Enter GroupNo please");
                groupNo = Console.ReadLine();
                Console.WriteLine(groupNo);

            } while (Group.CheckGroupNo(groupNo));

            Group group = new Group(groupNo, 10);

            


        }
    }
}
