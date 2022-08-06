using ClassesWithObjectModel;
using ObjectManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieFinder
{
    class Metods
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
            Console.Write("podaj długość filmu (w minutach): ");
            model.TimeMinutes = int.Parse(Console.ReadLine());
            manager.Add(model);
        }
        public static void ShowMovies(Manager<MovieModel> manager)
        {
            foreach (MovieModel model in manager)
            {
                Console.WriteLine("ID: {0}", model.IDmovie);
                Console.WriteLine("Tytuł: {0}", model.Title);
                Console.WriteLine("Reżyser: {0}", model.Rezyser);
                //Console.Write("Rok premiery: {0}  |", model.DataPremiery);
                Console.WriteLine("Długość: {0}", model.TimeMinutes + " minuty");
                Console.WriteLine();
            }
        }
        public static void DeleteMovie(Manager<MovieModel> manager)
        {
            foreach (MovieModel model in manager)
            {
                Console.WriteLine("ID: {0}", model.IDmovie);
                Console.WriteLine("Tytuł: {0}", model.Title);
                Console.WriteLine("Reżyser: {0}", model.Rezyser);
                //Console.Write("Rok premiery: {0}  |", model.DataPremiery);
                Console.WriteLine("Długość: {0}", model.TimeMinutes + " minuty");
                Console.WriteLine();
            }
            int idSerach;
            Console.Write("Podaj numer ID filmu, który chcesz usunąć: ");
            idSerach = int.Parse(Console.ReadLine());
            var movie = manager.list.Find(x => x.IDmovie == idSerach);
            manager.Remove(movie);
        }
    }
}
