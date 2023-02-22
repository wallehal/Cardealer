using carMenu;
using serviceMenu;
using System;

// Holding information to user regarding the main menu choices
namespace mainMenu
{
    namespace carMenu
    {
        namespace serviceMenu
        {


        class FirstClass {
        public static void Main(string[] args) {
            // Cleaning up the screen
            Console.Clear();
            // Welcomming the user and giving instructions
            Console.WriteLine("Välkommen till vår bilfirma!\n\nVänligen skriv in ditt namn och mailadress nedanför\n------------------------------------------------");
            Console.WriteLine("Namn:");
            String namn = Console.ReadLine();
            Console.WriteLine("Mailadress:");
            String mail = Console.ReadLine();


            // Menu choices
            string[] mainOptions = new string[] { "Sälj bil\t\t", "Köp bil\t\t", "Service\t\t", "Avsluta programmet\t" };
            // Defining which menu choice is first, and holding the user's choice
            int mainSelect = 0;

            while (true) {
                // Clean up for menu
                Console.Clear();
                // Removing the cursor
                Console.CursorVisible = false;

                // Higlighting the menu choices when picked
                if (mainSelect == 0) {
                    Console.WriteLine("[x] " + mainOptions[0] + "<<<<");
                    Console.WriteLine("[ ] " + mainOptions[1]);
                    Console.WriteLine("[ ] " + mainOptions[2]);
                    Console.WriteLine("[ ] " + mainOptions[3]);
                }
                else if (mainSelect == 1) {
                    Console.WriteLine("[ ] " + mainOptions[0]);
                    Console.WriteLine("[x] " + mainOptions[1] + "<<<<");
                    Console.WriteLine("[ ] " + mainOptions[2]);
                    Console.WriteLine("[ ] " + mainOptions[3]);
                }
                else if (mainSelect == 2) {
                    Console.WriteLine("[ ] " + mainOptions[0]);
                    Console.WriteLine("[ ] " + mainOptions[1]);
                    Console.WriteLine("[x] " + mainOptions[2] + "<<<<");
                    Console.WriteLine("[ ] " + mainOptions[3]);
                }
                else if (mainSelect == 3) {
                    Console.WriteLine("[ ] " + mainOptions[0]);
                    Console.WriteLine("[ ] " + mainOptions[1]);
                    Console.WriteLine("[ ] " + mainOptions[2]);
                    Console.WriteLine("[x] " + mainOptions[3] + "<<<<");
                }
                // Holding the users pick on the arrowkeys
                var keyPressed = Console.ReadKey();

                // Checking that the menu choice isn't at the bottom 
                if (keyPressed.Key == ConsoleKey.DownArrow && mainSelect != mainOptions.Length - 1) {
                    mainSelect++;
                }
                // Checking that the menu choice isn't at the top
                else if (keyPressed.Key == ConsoleKey.UpArrow && mainSelect >= 1) {
                    mainSelect--;
                }
                // When user presses Enter, they'll be redirected to new area
                else if (keyPressed.Key == ConsoleKey.Enter) {
                    switch (mainSelect) {
                        case 0:
                            SecondClass.FirstChoice();
                            break;
                        case 1:
                            ThirdClass.SecondChoice();
                            break;
                        case 2:
                            FourthClass.ThirdChoice();
                            break;
                        case 3:
                            EndChoice();
                            break;
                    }
                }
            }
        }
        // End program
        public static void EndChoice(){
            Console.Clear();
            Console.WriteLine("Du har valt att avsluta programmet!\n\nTryck Enter för att fortätta");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Programmet har avslutats!");
            Environment.Exit(1);
        }
    }
}
}
}