using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibPassword
{
    public class PasswordChecker
    {
        public static bool ValidatePassword(string password)
        {
            if (password.Length >= 8
               && password.Length <= 20)
                return true;
            else return false;

        }

        public static bool ValidatePasswordLower(string password)
        {
            if (password == password.ToLower())
                return false;
            else return true;
        }

        public static bool ValidatePasswordUpper(string password)
        {
            if (password == password.ToUpper())
                return false;
            else return true;
        }
        public static bool ValidatePasswordDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidatePasswordSpecial(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == '#' || password[i] == '$' || password[i] == '%' || password[i] == '^' || password[i] == '&' || password[i] == '_')
                {
                    return true;
                }
            }
            return false;
        }
    }
}


