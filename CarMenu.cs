using System;
// Immport libary to use lists
using System.Collections.Generic;

namespace carMenu
{
    // Main menu choice 2
    public static class ThirdClass
    {
        public static void SecondChoice() {
            // Cleaning up screen
            Console.Clear();
            // Menu choices
            Console.WriteLine("Du har valt att köpa en ny bil\n\nVälj en bil nedanför\n-----------------------");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
