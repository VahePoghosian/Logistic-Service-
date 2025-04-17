
using LogistycSystem2.UI;
using LogysticSystemService.UI.Admin;

namespace LogistycSystem2.Welcome
{
    public static class Welcome
    {
        public static void WelcomeMessage()
        {
            Console.Title = "Logistic system";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to our logystic company!");
            Console.WriteLine("Login as Admin (Select 1)\nLogin as User(Select 2)");

        }
    }
}
