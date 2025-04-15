using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogistycSystem2.UI
{
    public static class Login
    {
        public static string Login1 = "Vahe";
        public static string Password = "1234";
        public static string GetSecretInput(string secret)
        {
            int maxAttempts = 4;
            int attempts = 0;
            while (attempts < maxAttempts)
            {
                bool isPrompt = true;
                StringBuilder input = new StringBuilder();
                while (true)
                {
                    if (isPrompt)
                    {
                        Console.WriteLine($"{secret} (Attempt {attempts + 1} of {maxAttempts}):");
                    }
                    isPrompt = false;
                    ConsoleKeyInfo inputkey = Console.ReadKey(true);
                    if (inputkey.Key == ConsoleKey.Enter)
                    {
                        if (input.Length == 4)
                        {
                            Console.WriteLine("\nCode accepted!");
                            return input.ToString();
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter exactly 4 digits.");
                            Console.Clear();
                            isPrompt = true;
                            continue;
                        }
                    }
                    if (inputkey.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input.Remove(input.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                    else if (inputkey.Key != ConsoleKey.Backspace)
                    {
                        input.Append(inputkey.KeyChar);
                        Console.Write("*");
                    }
                }
                attempts++;
            }
            Console.WriteLine("Too many failed attempts! Program blocked.");
            Environment.Exit(0);
            return null;
        }
    }
}

