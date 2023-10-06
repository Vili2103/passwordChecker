using System.Collections.Specialized;
using System.ComponentModel.Design;


    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a password");
                Console.ResetColor();
                string password = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;

                if (checkLength(password) && checkUpper(password) && checkSpecial(password) && checkWhiteSpace(password))
                {
                    Console.WriteLine("The password is good enough");
                    break;
                }
                else
                    Console.WriteLine("This password is not strong enough");

            }

        }

        public static bool checkLength(string password)
        {
            if (password.Length >= 8 && password.Length <= 14)
                return true;
            else Console.WriteLine("Password length should be between 8 and 14 characters");
            return false;
        }

        public static bool checkUpper(string password)
        {
            if (password.ToLower() != password)
                return true;
            else
                Console.WriteLine("Password should contain at least 1 capital letter");
            return false;
        }

        public static bool checkSpecial(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                    return true;
            }
            Console.WriteLine("Passwords should contain at least 1 special character");
            return false;
        }

        public static bool checkWhiteSpace(string password)
        {
            string trimmed = password.Replace(" ", "");
            if ( trimmed == password)
                return true;

            Console.WriteLine("Passwords should not contain empty space");
            return false;
        }

    }