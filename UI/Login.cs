using LogysticSystemService.UI.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogistycSystem2.UI
{
    public class Login
    {
        List<AdminUser> users = new List<AdminUser>()
        {
            new AdminUser("admin", "Vahe123"),
            new AdminUser("user1", "pass123"),
            new AdminUser("alice", "qwerty")
        };
        public static void LoginSystem(List<AdminUser> users)
        {
            int maxAttempts = 4;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.Write($"Login (Attempt {attempts + 1} of {maxAttempts}): ");
                string username = Console.ReadLine();

                string password = GetSecretInput("Password");

                bool success = users.Exists(u => u.Username == username && u.Password == password);

                if (success)
                {
                    Console.WriteLine($"\nAccess granted. Welcome, {username}!");
                    AdminOrUser();
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("\nIncorrect login or password.\n");
                    Console.ResetColor();

                    attempts++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Too many failed attempts! Program blocked.");
            Console.ResetColor();
            Environment.Exit(0);
        }

        public static string GetSecretInput(string prompt)
        {
            StringBuilder input = new StringBuilder();
            Console.Write($"{prompt}: ");
            Console.Title = "Login System";

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    input.Append(key.KeyChar);
                    Console.Write("*");
                }
            }

            return input.ToString();
        }

        public static int AdminOrUser()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.KeyChar >= '1' && keyInfo.KeyChar <= '3')
            {
                switch (keyInfo.KeyChar)
                {
                    case '1':
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write("*");
                        }
                        return 1;
                        break;
                    case '2':
                        Console.WriteLine("You selected User Menu;");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write("*");
                        }
                        Console.WriteLine("\nOptions for  User");
                        return 2;
                        break;
                    case '3':
                        Console.Write("Exiting...");
                        for (int i = 0; i < 4; i++)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("*");

                        }
                        return 3;
                    default:
                        break;
                }
                return 3 ;


            }
            else
            {
                Console.WriteLine("Invalid number pressed. Please press 1, 2, or 3.");
            }
            return 3 ;

        }
        public static void ShowMenu()
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Option One");
            Console.WriteLine("2. Option Two");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose Option One.");
                    break;
                case "2":
                    Console.WriteLine("You chose Option Two.");
                    break;
                case "3":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

    }



}