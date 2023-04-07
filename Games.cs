using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE_Robin
{
    internal class Games
    {
        public string Name;
        public string Genre;
        public string Studio;
        public int ReleaseYear;
        public double Rating;


        public void RegisterGame()
        {
            Console.Clear();
            Console.WriteLine("\n------Register your game------\n");

            Console.Write("\nName: ");
            Name = Console.ReadLine();

            Console.Write("\nGenre: ");
            Genre = Console.ReadLine();

            Console.Write("\nStudio: ");
            Studio = Console.ReadLine();

            Console.Write("\nRelease Year: ");
            ReleaseYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nRating: ");
            Rating = Convert.ToDouble(Console.ReadLine());
        }
    }
}
