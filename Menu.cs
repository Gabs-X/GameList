using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace TDE_Robin
{
    internal class Menu
    {
        public static void ViewMenu()
        {
            List<Games> gamesList = new List<Games>();
            bool menuLoop = true;
            while (menuLoop)
            {
                Console.Clear();
                Console.WriteLine("\n---------Menu---------\n");

                Console.WriteLine("\n1 - Register your game" +
                    "\n2 - List Games" +
                    "\n3 - Highest Rated Games" +
                    "\n4 - Export to file(JSON)" +
                    "\n5 - Reading File" +
                    "\n0 - Exit");
                char option = Convert.ToChar(Console.ReadKey().KeyChar);
                switch (option)
                {
                    case '1':
                        Console.WriteLine("\n\nHow many games you be registered ? ");
                        int gamesAmount = Convert.ToInt16(Console.ReadLine());

                        for (int i = 1; i <= gamesAmount; i++)
                        {
                            Games games = new Games();
                            games.RegisterGame();
                            gamesList.Add(games);
                        }
                        Console.WriteLine("\nPress Enter to continue...");
                        Console.Read();
                        break;

                    case '2':
                        foreach (Games item in gamesList)
                        {
                            Console.Write($"\n\nGame Name: {item.Name} -- Game Genre: {item.Genre} -- Studio: {item.Studio} -- Released Date: {item.ReleaseYear} -- Rating: {item.Rating}\n");

                        }
                        Console.WriteLine("\nPress Enter to continue...");
                        Console.Read();
                        break;

                    case '3':
                        List<Games> gamesByRating = (List<Games>)gamesList.OrderByDescending(p => p.Rating).ToList();
                        foreach (Games gamesRating in gamesByRating)
                        {
                            Console.Write($"\n\nGame Name: {gamesRating.Name} -- Rating: {gamesRating.Rating}\n");
                        }
       
                        Console.WriteLine("\nPress Enter to continue...");
                        Console.Read();
                        break;

                    case '4':
                        string pathIncomplet = "";

                        Console.Write("\nEnter the path to create the file: ");
                        pathIncomplet = Console.ReadLine();
                        string gameJson = JsonConvert.SerializeObject(gamesList);
                        if (pathIncomplet != "")
                        {
                            string path = pathIncomplet + "/gamesList.json";

                            using (StreamWriter writer = File.CreateText(path))
                            {

                                writer.WriteLine(gameJson);
                            }
                        }

                        Console.WriteLine("\nPress Enter to continue...");
                        Console.Read();
                        break;

                    case '5':

                        Console.WriteLine("\nPress Enter to continue...");
                        Console.Read();
                        break;

                    case '0':
                        menuLoop = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid Value\n");
                        Console.WriteLine("\nPress Enter to continue...");
                        Console.Read();
                        break;


                }


            }

        }
    }
}
