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
            menu.AddItem(3, "Delete Movie");
            menu.AddItem(4, "Add Post");
            menu.AddItem(5, "Exit");
            int choise;
            do
            {
                choise = menu.Choice();
                switch(choise)
                {
                    case 1:
                        Metods.ShowMovies(manager);
                        break;
                    case 2:
                        Metods.AddMovie(manager);
                        break;
                    case 3:
                        Metods.DeleteMovie(manager);
                        break;
                }
                Console.ReadKey();

            } while (choise != 5);
        }
    }
}
