using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
    class User : IAccount
    {
        private static int id;

        private string _password;
        public int Id { get; }

        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }


        public User(string email, string password)
        {
            Id = ++id;
            Email = email;
            Password = password;
        }



       
        

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}");
        }

       

        public bool PasswordChecker(string password)
        {
            bool HasUpper = false;
            bool HasLower = false;
            bool HasDigit = false;

            if (password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper(item))
                    {
                        HasUpper = true;
                    }

                    if (char.IsLower(item))
                    {
                        HasLower = true;
                    }

                    if (char.IsDigit(item))
                    {
                        HasDigit = true;
                    }
                }


            }
            bool result = HasUpper & HasLower & HasDigit;
            return result;
        }
    }
}
