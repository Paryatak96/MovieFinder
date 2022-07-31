﻿using Manager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesWithObjectModel
{
    public class MovieModel : IElementWithId
    {
        public MovieModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public int TimeMinutes { get; set; }
    }
}