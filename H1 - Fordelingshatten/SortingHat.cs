using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1___Fordelingshatten
{
    enum House
    {
        Gryffindor,
        Hufflepuff,
        Ravenclaw,
        Slytherin
    }

    internal class SortingHat
    {
        /// <summary>
        /// What no one will tell you is that most of the time,
        /// the sorting hat is just picking houses at random.
        /// </summary>
        /// <returns></returns>
        public House ChooseHouse()
        {
            // Inline solution
            // return Enum.GetValues<House>()[new Random().Next(Enum.GetValues<House>().Length)];

            // More readable solution
            Random r = new Random();

            House[] houseArray = Enum.GetValues<House>(); // Store all enum values of type house in an array.

            int randomIndex = r.Next(houseArray.Length); // Choose a random number between 0 and the number of houses -1.

            House h = houseArray[randomIndex]; // Get the randomly chosen house from the array.
            return h; // Return that house.
        }
    }
}
