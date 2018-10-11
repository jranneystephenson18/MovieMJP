using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermMovie
{
    class Movies
    {
        public List<Movie> MoviesList = new List<Movie>();

       public void AddMovie()
        {
            Movie movie = new Movie();
            Console.WriteLine("Enter movie name: ");
            movie.Name = Console.ReadLine();

            Console.WriteLine("Enter actor name: ");
            movie.Actor = Console.ReadLine();

            Console.WriteLine("Enter director name: ");
            movie.Director = Console.ReadLine();

            Console.WriteLine("Enter genre: ");
            movie.Genre = Console.ReadLine();
            Console.WriteLine();
            this.MoviesList.Add(movie);
        }

        public Movie FindMovie()
        {
            Console.WriteLine("Enter movie name: ");
            string moviename = Console.ReadLine();
            return this.MoviesList.FirstOrDefault(m => m.Name.ToLower() == moviename.ToLower());
        }

        public Movie FindMovieByActor()
        {
            Console.WriteLine("Enter actor name: ");
            string actorname = Console.ReadLine();
            return this.MoviesList.FirstOrDefault(m => m.Actor.ToLower() == actorname.ToLower());
        }

        public Movie FindMovieByDirector()
        {
            Console.WriteLine("Enter director name: ");
            string directorname = Console.ReadLine();
            return this.MoviesList.FirstOrDefault(m => m.Director.ToLower() == directorname.ToLower());
        }

        public void DisplayMovie(Movie movie)
        {
            if(movie==null)
            {
                Console.WriteLine("No movie found.");
            }
            else
            {
                Console.WriteLine("The movie's details are:  ");
                Console.WriteLine("Name :  " + movie.Name);
                Console.WriteLine("Actor :  " + movie.Actor);
                Console.WriteLine("Director :  " + movie.Director);
                Console.WriteLine("Genre :  " + movie.Genre);
            }

            Console.WriteLine();
        }
    }
}
