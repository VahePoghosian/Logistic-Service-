using LogistycSystem2.UI;
using LogistycSystem2.Welcome;
using LogysticSystemService.Moduls;
using System.ComponentModel;

Welcome.WelcomeMessage();

 int option = Login.AdminOrUser();

switch (option)
{
    case 1:
        break;


        case 2:
        Console.WriteLine("Enter the City to Transfer from");
        string From = Console.ReadLine();
        Console.WriteLine("Enter the City to Transfer To");
        string To = Console.ReadLine();
        Console.WriteLine("Enter the Container Type(Open/Close)");
        string ContainerType = Console.ReadLine();
        Console.WriteLine("Enter the year");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Is it operable?");
        string answ = Console.ReadLine();
        Console.WriteLine("Enter car mark");
        string carMark = Console.ReadLine();
        Console.WriteLine("Enter the car model");
        string model = Console.ReadLine();

        break;
}

