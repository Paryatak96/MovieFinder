using ClassesWithObjectModel;
using ObjectManager;
using System;
using System.Collections.Generic;
using System.Text;
using TableToDisplay;

namespace MovieFinder
{
    class Methods
    {
        public static void AddMovie(Manager<MovieModel> manager)
        {
            MovieModel model = new MovieModel();
            Console.Write("Wprowadź ID filmu: ");
            model.IDmovie = int.Parse(Console.ReadLine());
            Console.Write("Podaj tytuł filmu: ");
            model.Title = Console.ReadLine();
            Console.Write("Podaj reżysera filmu: ");
            model.Rezyser = Console.ReadLine();
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
                    table.AddRow(model.IDmovie.ToString(), model.Title, model.Rezyser, model.TimeMinutes.ToString());
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
                table.AddRow(model.IDmovie.ToString(), model.Title, model.Rezyser, model.TimeMinutes.ToString());
            }
            Console.WriteLine(table.ToString());

            int idSerach;
            Console.Write("Podaj numer ID filmu, który chcesz usunąć: ");
            idSerach = int.Parse(Console.ReadLine());
            var movie = manager.list.Find(x => x.IDmovie == idSerach);
            manager.Remove(movie);
        }
    }
}
