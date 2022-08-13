using ClassesWithObjectModel;
using MenuLib;
using ObjectManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieFinder
{
    class MenuSide
    {
        public static void MainMenu()
        {
            Manager<MovieModel> manager = new Manager<MovieModel>("filmy.txt");
            Menu<int> menu = new Menu<int>("    " + "MovieFinder");
            menu.AddItem(1, "Show Movies");
            menu.AddItem(2, "Add Movie");
            menu.AddItem(3, "Delete Movie");
            menu.AddItem(4, "Show All Movies");
            menu.AddItem(5, "Exit");

            int choise;
            do
            {
                choise = menu.Choice();
                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        MenuOptionOne();
                        break;
                    case 2:
                        Methods.AddMovie(manager);
                        break;
                    case 3:
                        Methods.DeleteMovie(manager);
                        break;
                }
                Console.ReadKey();

            } while (choise != 5);
        }
        public static void MenuOptionOne()
        {
            Manager<MovieModel> manager = new Manager<MovieModel>("filmy.txt");
            Menu<int> menu = new Menu<int>("    " + "Show Movies");
            menu.AddItem(1, "Comedy");
            menu.AddItem(2, "Horror");
            menu.AddItem(3, "Thiller");
            menu.AddItem(4, "Sci-Fi");
            menu.AddItem(5, "Biography");
            menu.AddItem(6, "Back to Main Menu");
            int choise;
            do
            {
                string type;
                choise = menu.Choice();
                switch (choise)
                {
                    case 1:
                        type = "Comedy";
                        Methods.ShowMovies(manager, type);
                        break;
                    case 2:
                        type = "Horror";
                        Methods.ShowMovies(manager, type);
                        break;
                    case 3:
                        type = "Thiller";
                        Methods.ShowMovies(manager, type);
                        break;
                    case 4:
                        type = "Sci-Fi";
                        Methods.ShowMovies(manager, type);
                        break;
                    case 5:
                        type = "Biography";
                        Methods.ShowMovies(manager, type);
                        break;
                    case 6:
                        MainMenu();
                        break;
                }
                Console.ReadKey();

            } while (true);
        }
    }
}
