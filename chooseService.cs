using System;

// Main menu choice 3
namespace serviceMenu {
    public static class FourthClass {
        public static void ThirdChoice() {
            // Menu choices
            string[] serviceOptions = new string[] { "Boka bilservice\t\t", "Boka reparation\t\t", "Garantiärende\t\t", "Tillbaka till huvudmeny\t" };
            // Defining which menu choice is first, and holding the user's choice
            int serviceSelect = 0;
            // Giving y a sential value for the while-loop
            int y = 0;

            while (y != 1) {
                // Clean up for menu
                Console.Clear();
                // Menu title
                Console.WriteLine("Välj ett av valen nedanför för att skapa ett serviceärende\n----------------------------------------------------------");

                // Higlighting the menu choices when picked
                if (serviceSelect == 0) {
                    Console.WriteLine("[x] " + serviceOptions[0] + "<<<<");
                    Console.WriteLine("[ ] " + serviceOptions[1]);
                    Console.WriteLine("[ ] " + serviceOptions[2]);
                    Console.WriteLine("\n[ ] " + serviceOptions[3]);
                }
                else if (serviceSelect == 1) {
                    Console.WriteLine("[ ] " + serviceOptions[0]);
                    Console.WriteLine("[x] " + serviceOptions[1] + "<<<<");
                    Console.WriteLine("[ ] " + serviceOptions[2]);
                    Console.WriteLine("\n[ ] " + serviceOptions[3]);
                }
                else if (serviceSelect == 2) {
                    Console.WriteLine("[ ] " + serviceOptions[0]);
                    Console.WriteLine("[ ] " + serviceOptions[1]);
                    Console.WriteLine("[x] " + serviceOptions[2] + "<<<<");
                    Console.WriteLine("\n[ ] " + serviceOptions[3]);
                }
                else if (serviceSelect == 3) {
                    Console.WriteLine("[ ] " + serviceOptions[0]);
                    Console.WriteLine("[ ] " + serviceOptions[1]);
                    Console.WriteLine("[ ] " + serviceOptions[2]);
                    Console.WriteLine("\n[x] " + serviceOptions[3] + "<<<<");
                }
                // Holding the users pick on the arrowkeys
                var keyPressed = Console.ReadKey();

                // Checking that the menu choice isn't at the bottom 
                if (keyPressed.Key == ConsoleKey.DownArrow && serviceSelect != serviceOptions.Length - 1) {
                    serviceSelect++;
                }
                // Checking that the menu choice isn't at the top
                else if (keyPressed.Key == ConsoleKey.UpArrow && serviceSelect >= 1) {
                    serviceSelect--;
                }
                // When user presses Enter, they'll get more information on the cars
                else if (keyPressed.Key == ConsoleKey.Enter) {
                    // Menu choice 1
                    if (serviceSelect == 0) {
                        Console.Clear();
                        // Printing that menu choice 1 has been made, and regrister the user's car details
                        Console.WriteLine("Du har valt att boka bilservice!\n\nVänligen fyll i information om din bil nedanför\n------------------------------------------------");
                        Console.WriteLine("Bilmärke:");
                        Console.ReadLine();
                        Console.WriteLine("Registeringsnummer:");
                        Console.ReadLine();
                        Console.WriteLine("Nuvarande miltal:");
                        Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Anlending till bokning av bilservice:");
                        Console.ReadLine();
                        // Cleaning up the screen, waiting for the user to press Enter
                        Console.Clear();
                        Console.WriteLine("Nu är din begäran mottagen och vi återkopplar oftast inom 24h!\n\nTryck Enter för att återvända till menyn!");
                        Console.ReadKey();
                    }
                    // Menu choice 2
                    else if (serviceSelect == 1) {
                        Console.Clear();
                        // Printing that menu choice 2 has been made, and regrister the user's car details
                        Console.WriteLine("Du har valt att boka reparation till din bil!\n\nVänligen fyll i information om din bil nedanför\n------------------------------------------------");
                        Console.WriteLine("Bilmärke:");
                        Console.ReadLine();
                        Console.WriteLine("Registeringsnummer:");
                        Console.ReadLine();
                        Console.WriteLine("Nuvarande miltal:");
                        Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Anlending till bokning av reperation:");
                        Console.ReadLine();
                        // Cleaning up the screen, waiting for the user to press Enter
                        Console.Clear();
                        Console.WriteLine("Nu är din begäran mottagen och vi återkopplar oftast inom 24h!\n\nTryck Enter för att återvända till menyn!");
                        Console.ReadKey();
                    }
                    // Menu choice 3
                    else if (serviceSelect == 2) {
                        Console.Clear();
                        // Printing that menu choice 3 has been made, and regrister the user's car details
                        Console.WriteLine("Du har valt att skapa ett garantiärende!\n\nVänligen fyll i information om din bil nedanför\n------------------------------------------------");
                        Console.WriteLine("Bilmärke:");
                        Console.ReadLine();
                        Console.WriteLine("Registeringsnummer:");
                        Console.ReadLine();
                        Console.WriteLine("Nuvarande miltal:");
                        Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Anlending till skapande av ett garantiärende");
                        Console.ReadLine();
                        // Cleaning up the screen, waiting for the user to press Enter
                        Console.Clear();
                        Console.WriteLine("Nu är din begäran mottagen och vi återkopplar oftast inom 24h!\n\nTryck Enter för att återvända till menyn!");
                        Console.ReadKey();
                    }
                    // Menu choice 4, go back to main menu
                    else if (serviceSelect == 3) {
                        Console.Clear();
                        Console.WriteLine("Du har valt att återvända till Huvudmenyn!\nTryck Enter för att fortsätta!");
                        Console.ReadKey(); 
                        y++;

                    }
                }
            }
        }
    }
}