using ClassesWithObjectModel;
using MenuLib;
using ObjectManager;
using System;
using System.Collections.Generic;
using System.Text;
using Users;

namespace MovieFinder
{
    class MenuSide
    {
        public static void MainMenuLog()
        {
            Manager<UsersModel> manager = new Manager<UsersModel>("users.txt");
            Menu<int> menu = new Menu<int>("    " + "Welcome To Movie Finder");
            menu.AddItem(1, "Log In");
            menu.AddItem(2, "Register");
            menu.AddItem(3, "Exit");

            int choise;
            do
            {
                choise = menu.Choice();
                switch (choise)
                {
                    case 1:
                        var bvalue = Methods.LogInUser(manager);
                        if(bvalue == true)
                        {
                            MainMenu();
                        }
                        else
                        {
                            MainMenuLog();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Methods.AddUser(manager);
                        break;
                }
                Console.ReadKey();

            } while (choise != 3);
        }
        public static void MainMenu()
        {
            Menu<int> menu = new Menu<int>("    " + "MovieFinder");
            menu.AddItem(1, "Movies");
            menu.AddItem(2, "Serials");
            menu.AddItem(3, "Log Out");

            int choise;
            do
            {
                choise = menu.Choice();
                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        MainMenuMovies();
                        break;
                    case 2:
                        Console.Clear();
                        MainMenuSerials();
                        break;
                    case 3:
                        MainMenuLog();
                        break;
                }
                Console.ReadKey();

            } while (true);
        }
        // Movies
        public static void MainMenuMovies()
        {
            Manager<MovieModel> manager = new Manager<MovieModel>("filmy.txt");
            Menu<int> menu = new Menu<int>("    " + "MovieFinder");
            menu.AddItem(1, "Show Movies");
            menu.AddItem(2, "Add Movie");
            menu.AddItem(3, "Delete Movie");
            menu.AddItem(4, "Show All Movies");
            menu.AddItem(5, "Back to Main Menu");

            int choise;
            do
            {
                choise = menu.Choice();
                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        MenuOptionOneMovies();
                        break;
                    case 2:
                        Methods.AddMovie(manager);
                        break;
                    case 3:
                        Methods.DeleteMovie(manager);
                        break;
                    case 4:
                        Methods.ShowAllMovies(manager);
                        break;
                    case 5:
                        MainMenu();
                        break;
                }
                Console.ReadKey();

            } while (true);
        }
        public static void MenuOptionOneMovies()
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
                        MainMenuMovies();
                        break;
                }
                Console.ReadKey();

            } while (true);
        }
        // Serials
        public static void MainMenuSerials()
        {
            Manager<SerialModel> manager = new Manager<SerialModel>("seriale.txt");
            Menu<int> menu = new Menu<int>("    " + "MovieFinder");
            menu.AddItem(1, "Show Serials");
            menu.AddItem(2, "Add Serial");
            menu.AddItem(3, "Delete Serial");
            menu.AddItem(4, "Show All Serials");
            menu.AddItem(5, "Back to Main Menu");

            int choise;
            do
            {
                choise = menu.Choice();
                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        MenuOptionOneSerials();
                        break;
                    case 2:
                        Methods.AddSerial(manager);
                        break;
                    case 3:
                        Methods.DeleteSerial(manager);
                        break;
                    case 4:
                        Methods.ShowAllSerials(manager);
                        break;
                    case 5:
                        MainMenu();
                        break;
                }
                Console.ReadKey();

            } while (true);
        }
        public static void MenuOptionOneSerials()
        {
            Manager<MovieModel> manager = new Manager<MovieModel>("seriale.txt");
            Menu<int> menu = new Menu<int>("    " + "Show Serials");
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
