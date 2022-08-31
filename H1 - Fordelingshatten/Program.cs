using System;

namespace H1___Fordelingshatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortingHat sh = new SortingHat(); // Creating sorting hat object
            Console.WriteLine(sh.ChooseHouse()); // Choose a random house and print it to console.
            Console.ReadKey();
        }
    }
}
