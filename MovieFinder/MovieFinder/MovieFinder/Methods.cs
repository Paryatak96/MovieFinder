using ClassesWithObjectModel;
using ObjectManager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TableToDisplay;
using Users;

namespace MovieFinder
{
    class Methods
    {
        // Movie
        public static void AddMovie(Manager<MovieModel> manager)
        {
            MovieModel model = new MovieModel();
            Console.Write("Wprowadź ID filmu: ");
            model.IDmovie = int.Parse(Console.ReadLine());
            Console.Write("Podaj tytuł filmu: ");
            model.Title = Console.ReadLine();
            Console.Write("Podaj reżysera filmu: ");
            model.Director = Console.ReadLine();
            Console.Write("Podaj rok premiery filmu: ");
            int year = int.Parse(Console.ReadLine());
            model.DataPremiery.AddYears(year);
            Console.Write("Podaj rodzaj filmu: ");
            model.TypeMovie = Console.ReadLine();
            Console.Write("podaj długość filmu (w minutach): ");
            model.TimeMinutes = int.Parse(Console.ReadLine());
            manager.Add(model);
        }
        public static void ShowMovies(Manager<MovieModel> manager, string type)
        {
            var table = new TableSource();

            table.SetHeaders("ID", "Title", "Director", "Time (in minutes)");

            foreach (MovieModel model in manager)
            {
                if(model.TypeMovie == type)
                {
                    table.AddRow(model.IDmovie.ToString(), model.Title, model.Director, model.TimeMinutes.ToString());
                }
            }
            Console.WriteLine(table.ToString());
        }
        public static void DeleteMovie(Manager<MovieModel> manager)
        {
            var table = new TableSource();
            table.SetHeaders("ID", "Title", "Director", "Time (in minutes)");

            foreach (MovieModel model in manager)
            {
                table.AddRow(model.IDmovie.ToString(), model.Title, model.Director, model.TimeMinutes.ToString());
            }
            Console.WriteLine(table.ToString());

            int idSerach;
            Console.Write("Podaj numer ID filmu, który chcesz usunąć: ");
            idSerach = int.Parse(Console.ReadLine());
            var movie = manager.list.Find(x => x.IDmovie == idSerach);
            manager.Remove(movie);
        }
        public static void ShowAllMovies(Manager<MovieModel> manager)
        {
            var table = new TableSource();

            table.SetHeaders("ID", "Title", "Director", "Type","Time (in minutes)");

            foreach (MovieModel model in manager)
            {
                table.AddRow(model.IDmovie.ToString(), model.Title, model.Director, model.TypeMovie, model.TimeMinutes.ToString());
            }
            Console.WriteLine(table.ToString());
        }
        // Serial
        public static void AddSerial(Manager<SerialModel> manager)
        {
            SerialModel model = new SerialModel();
            Console.Write("Wprowadź ID serialu: ");
            model.IDserial = int.Parse(Console.ReadLine());
            Console.Write("Podaj tytuł serialu: ");
            model.Title = Console.ReadLine();
            Console.Write("Podaj reżysera serialu: ");
            model.Director = Console.ReadLine();
            Console.Write("Podaj ilość sezonów: ");
            model.Seasons = int.Parse(Console.ReadLine());
            Console.Write("Podaj rok premiery serialu: ");
            int year = int.Parse(Console.ReadLine());
            model.DataPremiery.AddYears(year);
            Console.Write("Podaj rodzaj serialu: ");
            model.TypeSerial = Console.ReadLine();
            Console.Write("podaj długość serialu (w minutach): ");
            model.TimeMinutes = int.Parse(Console.ReadLine());
            manager.Add(model);
        }
        public static void ShowSerials(Manager<SerialModel> manager, string type)
        {

            var table = new TableSource();

            table.SetHeaders("ID", "Title", "Director","Seasons", "Time (in minutes)");

            foreach (SerialModel model in manager)
            {
                if (model.TypeSerial == type)
                {
                    table.AddRow(model.IDserial.ToString(), model.Title, model.Director, model.Seasons.ToString(), model.TimeMinutes.ToString());
                }
            }
            Console.WriteLine(table.ToString());
        }
        public static void DeleteSerial(Manager<SerialModel> manager)
        {
            var table = new TableSource();
            table.SetHeaders("ID", "Title", "Director", "Season", "Time (in minutes)");

            foreach (SerialModel model in manager)
            {
                table.AddRow(model.IDserial.ToString(), model.Title, model.Director,model.Seasons.ToString(), model.TimeMinutes.ToString());
            }
            Console.WriteLine(table.ToString());

            int idSerach;
            Console.Write("Podaj numer ID filmu, który chcesz usunąć: ");
            idSerach = int.Parse(Console.ReadLine());
            var movie = manager.list.Find(x => x.IDserial == idSerach);
            manager.Remove(movie);
        }
        public static void ShowAllSerials(Manager<SerialModel> manager)
        {
            var table = new TableSource();

            table.SetHeaders("ID", "Title", "Director", "Seasons", "Type", "Time (in minutes)");

            foreach (SerialModel model in manager)
            {
                table.AddRow(model.IDserial.ToString(), model.Title, model.Director, model.Seasons.ToString(), model.TypeSerial, model.TimeMinutes.ToString());
            }
            Console.WriteLine(table.ToString());
        }
        // Users
        public static void AddUser(Manager<UsersModel> manager)
        {
            Label:
            UsersModel model = new UsersModel();
            Console.Write("Wprowadź Login: ");
            model.Login = Console.ReadLine();
            foreach (UsersModel mod in manager)
            {
                if (mod.Login == model.Login)
                {
                    Console.WriteLine("Taki login już istnieje, wprowadź inny login!");
                    goto Label;
                }
            }
            Console.Write("Wprowadź Hasło: ");
            model.Password = Console.ReadLine();
            Console.Write("Podaj swoje imię: ");
            model.Imię = Console.ReadLine();
            Console.Write("Podaj swoje nazwisko: ");
            model.Nazwisko = Console.ReadLine();
            Console.Write("Podaj swój adres E-mail: ");
            model.Email = Console.ReadLine();
            manager.Add(model);
        }
        public static bool LogInUser(Manager<UsersModel> manager)
        {
            Console.Write("Podaj swój login: ");
            string login = Console.ReadLine();
            foreach (UsersModel model in manager)
            {
                if (model.Login == login)
                {
                    Console.Write("Podaj swoje hasło: ");
                    string password = Console.ReadLine();
                    if (model.Password == password)
                    {
                        return true;
                    }
                }
            }
            Console.WriteLine("Niepoprawny login lub hasło - spróbuj jeszcze raz!");
            Thread.Sleep(2000);
            return false;
        }
    }
}
