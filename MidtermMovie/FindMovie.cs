﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermMovie
{
    public class Movie
    {
        public string NameofMovie { get; set; }
        public string Actor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public Movie(string nameOfMovie, string actor, string genre, string director)

        {
            this.NameofMovie = nameOfMovie;
            this.Actor = actor;
            this.Genre = genre;
            this.Director = director;
        }
    }
}