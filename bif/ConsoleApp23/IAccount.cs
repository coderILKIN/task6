using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
