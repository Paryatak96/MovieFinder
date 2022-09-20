using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesWithObjectModel
{
    interface IMovieModel
    {
        public string Title { get; set; }
        public int TimeMinutes { get; set; }
        public int IDmovie { get; set; }
        public string Director { get; set; }
        public string TypeMovie { get; set; }
        public DateTime DataPremiery { get; set; }
    }
}
