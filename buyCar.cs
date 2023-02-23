using System;

// Main menu choice 2
namespace carMenu {
    public static class ThirdClass {
        public static void SecondChoice() {   
            // Menu choices
            string[] carOptions = new string[] { "Volvo v90\t\tPris: 250 000 kr\t", "Mercedes GLC300\tPris: 559 900 kr\t", "BMW X1\t\tPris: 209 800 kr\t", "Tillbaka till huvudmeny\t" };
            // Defining which menu choice is first, and holding the user's choice
            int carSelect = 0;
            // Giving y a sential value for the while-loop
            int y = 0;

            while (y != 1) {
                // Clean up for menu
                Console.Clear();
                // Menu title
                Console.WriteLine("Välj ett av valen nedanför för att köpa en bil\n-----------------------------------------------");

                // Higlighting the menu choices when picked
                if (carSelect == 0) {
                    Console.WriteLine("[x] " + carOptions[0] + "<<<<");
                    Console.WriteLine("[ ] " + carOptions[1]);
                    Console.WriteLine("[ ] " + carOptions[2]);
                    Console.WriteLine("\n[ ] " + carOptions[3]);
                }
                else if (carSelect == 1) {
                    Console.WriteLine("[ ] " + carOptions[0]);
                    Console.WriteLine("[x] " + carOptions[1] + "<<<<");
                    Console.WriteLine("[ ] " + carOptions[2]);
                    Console.WriteLine("\n[ ] " + carOptions[3]);
                }
                else if (carSelect == 2) {
                    Console.WriteLine("[ ] " + carOptions[0]);
                    Console.WriteLine("[ ] " + carOptions[1]);
                    Console.WriteLine("[x] " + carOptions[2] + "<<<<");
                    Console.WriteLine("\n[ ] " + carOptions[3]);
                }
                else if (carSelect == 3) {
                    Console.WriteLine("[ ] " + carOptions[0]);
                    Console.WriteLine("[ ] " + carOptions[1]);
                    Console.WriteLine("[ ] " + carOptions[2]);
                    Console.WriteLine("\n[x] " + carOptions[3] + "<<<<");
                }
                // Holding the users pick on the arrowkeys
                var keyPressed = Console.ReadKey();

                // Checking that the menu choice isn't at the bottom 
                if (keyPressed.Key == ConsoleKey.DownArrow && carSelect != carOptions.Length - 1) {
                    carSelect++;
                }
                // Checking that the menu choice isn't at the top
                else if (keyPressed.Key == ConsoleKey.UpArrow && carSelect >= 1) {
                    carSelect--;
                }
                // When user presses Enter, they'll get more information on the cars
                else if (keyPressed.Key == ConsoleKey.Enter) {
                    // Menu choice 1, more information about the car
                    if (carSelect == 0) {
                        Console.Clear();
                        Console.WriteLine("Du har valt en svart Volvo V90! Kika nedan för mer information");
                        Console.WriteLine("---------------------------------------------------------------");
                        Console.WriteLine("Fordonstyp:\tKombi\nVäxellåda:\tAutomatisk\nÅrsmodell:\t2018\nMiltal:\t\t13 000");
                        Console.WriteLine("\n\nVi kommer att återkoppla inom 24h för att avsluta köpet!\n\nTryck Enter för att återvända till menyn");
                        Console.ReadLine();
                    }
                    // Menu choice 2, more information about the car
                    else if (carSelect == 1) {
                        Console.Clear();
                        Console.WriteLine("Du har valt en grå Mercedes GLC300! Kika nedan för mer information");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Fordonstyp:\tSUV\nVäxellåda:\tAutomatisk\nÅrsmodell:\t2022\nMiltal:\t\t2 000");
                        Console.WriteLine("\n\nVi kommer att återkoppla inom 24h för att avsluta köpet!\n\nTryck Enter för att återvända till menyn");
                        Console.ReadLine();
                    }
                    // Menu choice 3, more information about the car
                    else if (carSelect == 2) {
                        Console.Clear();
                        Console.WriteLine("Du har valt en vit BMW X1! Kika nedan för mer information");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Fordonstyp:\tSUV\nVäxellåda:\tAutomatisk\nÅrsmodell:\t2016\nMiltal:\t\t16 000");
                        Console.WriteLine("\n\nVi kommer att återkoppla inom 24h för att avsluta köpet!\n\nTryck Enter för att återvända till menyn");
                        Console.ReadLine();
                    }
                    // Menu choice 4, go back to main menu
                    else if (carSelect == 3) {
                        Console.Clear();
                        Console.WriteLine("Du har valt att återvända till Huvudmenyn!\n\nTryck Enter för att fortsätta!");
                        Console.ReadLine();
                        y++;

                    }
                }
            }
        }
    }
}