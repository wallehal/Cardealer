using System;

// Main menu choice 1
namespace sellCar {
    public static class SecondClass {
        public static void FirstChoice() {
            // Cleaning up the screen
            Console.Clear();
            // Printing that menu choice 1 has been made, and regrister the user's car details
            Console.WriteLine("Du har valt att sälja din bil!\n\nVänligen fyll i information om din bil nedanför\n------------------------------------------------");
            Console.WriteLine("Bilmärke:");
            Console.ReadLine();
            Console.WriteLine("Registeringsnummer:");
            Console.ReadLine();
            Console.WriteLine("Nuvarande miltal:");
            Convert.ToInt32(Console.ReadLine());
            // Cleaning up the screen, waiting for the user to press Enter
            Console.Clear();
            Console.WriteLine("Nu är din begäran mottagen och vi återkopplar oftast inom 24h!\n\nTryck Enter för att återvända till Huvudmenyn!");
            Console.ReadKey();

        }
    }
}