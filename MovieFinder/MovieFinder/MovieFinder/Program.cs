using MenuLib;
using ClassesWithObjectModel;
using Manager.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectManager;

namespace MovieFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager<MovieModel> manager = new Manager<MovieModel>("filmy.txt");
            Menu<int> menu = new Menu<int>("    " + "MovieFinder");
            menu.AddItem(1, "Show Movies");
            menu.AddItem(2, "Add Movie");
            menu.AddItem(3, "Search Movie");
            menu.AddItem(4, "Add Post");
            menu.AddItem(5, "Exit");
            int choise;
            do
            {
                choise = menu.Choice();
                switch(choise)
                {
                    case 1:
                        ShowMovies(manager);
                        break;
                    case 2:
                        AddMovie(manager);
                        break;
                    case 3:
                        Console.WriteLine("wybrano opcje c");
                        break;
                }
                Console.ReadKey();

            } while (choise != 5);
        }
        private static void AddMovie(Manager<MovieModel> manager)
        {
            MovieModel model = new MovieModel();
            Console.Write("Podaj tytuł filmu:");
            model.Title = Console.ReadLine();
            Console.Write("podaj długość filmu (w minutach):");
            model.TimeMinutes = int.Parse(Console.ReadLine());
            manager.Add(model);
        }
        private static void ShowMovies(Manager<MovieModel> manager )
        {
            int i = 1;
            foreach (MovieModel model in manager)
            {
                Console.WriteLine("ID: {0}", i);
                Console.WriteLine("Tytuł: {0}", model.Title);
                Console.WriteLine("Długość: {0}", model.TimeMinutes + " minuty");
                Console.WriteLine();
                i++;
            }
        }
    }
}
