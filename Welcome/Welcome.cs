
using LogistycSystem2.UI;

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
        public static bool  Login1(int index)
        {
            if(index == 1)
            {
                Console.WriteLine("Please enter your login and password");
                string login=Console.ReadLine();
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                    Login.GetSecretInput(password);
                if (login == Login.Login1 && password == Login.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
