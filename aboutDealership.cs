using System;

// Main menu choice 4
namespace aboutUs {
    public static class FifthClass {
        public static void FourthChoice()
        {
            // Cleaning up screen
            Console.Clear();
            // Information regarding the cardealership and workers
            Console.WriteLine("- OM OSS PÅ BILFIRMAN -\n");
            Console.WriteLine("Vi skapade företaget bara för någon månad för att köpa och sälja begagnade bilar. På en kort tid har personal styrkan växt för att ni ska få en utmärkt service!\n\nNedanför kan ni se kontaktinformation om ni har frågor!");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(@"
* * * * * * * * * * * * * * * * *    * * * * * * * * * * * * * * * * *
* /\_/\    Ola-conny [Säljare]  *    * (\_/)   Maria [Receptionist]  *
* ( o-o)                        *    * ( ^-^)                        *
* (    )   070-88899909         *    * ( U U)   072-00349029         *
* * * * * * * * * * * * * * * * *    * * * * * * * * * * * * * * * * *


* * * * * * * * * * * * * * * * *    * * * * * * * * * * * * * * * * *
*  /\_/)   Bert [VD]            *    * ()__()   Per [Säljare]        *
* ( ^-^)                        *    * (._. )                        *
* (    )   070-82883612         *    * /    \   075-48201473         *
* * * * * * * * * * * * * * * * *    * * * * * * * * * * * * * * * * *");
            // Waiting for user to press Enter
            Console.WriteLine("\n\n\nTryck Enter för att återvända till Huvudmenyn!");
            Console.ReadLine();
        }
    }
}