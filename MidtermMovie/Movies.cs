using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermMovie
{
    public class MovieMethods
    {

        public static void MoviesList(List<Movie> array)

        {
            Console.WriteLine("Enter movie name: ");
            string Name = Console.ReadLine();
            bool foundit = false;
            foreach (Movie x in array)
            {
                if (x.NameofMovie == Name)
                {
                    Console.WriteLine("The movie's details are:  ");
                    Console.WriteLine("Name :  " + x.NameofMovie);
                    Console.WriteLine("Actor :  " + x.Actor);
                    Console.WriteLine("Director :  " + x.Director);
                    Console.WriteLine("Genre :  " + x.Genre);
                    foundit = true;
                }
            }
            if (foundit == false)
            {
                Console.WriteLine("no movie found");
            }

        }

        public static void Actor(List<Movie> array)
        {
            Console.WriteLine("Enter actor name: ");
            string actorname = Console.ReadLine();
            bool foundit = false;
            foreach (Movie x in array)
            {
                if (x.Actor == actorname)
                {
                    Console.WriteLine("Name :  " + x.NameofMovie);
                    foundit = true;
                }
            }
            if (foundit == false)
            {
                Console.WriteLine("no actor found");
            }
        }



        public static void Director(List<Movie> array)
        {
            Console.WriteLine("Enter director name: ");
            string directorname = Console.ReadLine();
            bool foundit = false;
            foreach (Movie x in array)
            {
                if (x.Director == directorname)
                {
                    Console.WriteLine("Name :  " + x.NameofMovie);
                    foundit = true;
                }
            }
            if (foundit == false)
            {
                Console.WriteLine("Movie not found");
            }

        }

        public static void DisplayMovie(List<Movie> movie)
        {
            if (movie == null)
            {
                Console.WriteLine("No movie found.");
            }
            else foreach (Movie x in movie)
                {
                    Console.WriteLine("The movie's details are:  ");
                    Console.WriteLine("Name :  " + x.NameofMovie);
                    Console.WriteLine("Actor :  " + x.Actor);
                    Console.WriteLine("Director :  " + x.Director);
                    Console.WriteLine("Genre :  " + x.Genre);
                }

            Console.WriteLine();

        }
        public static void AddMovie(List<Movie> array)
        {
            
           Console.WriteLine("Enter movie name name: ");
           string name = Console.ReadLine();

            Console.WriteLine("Enter director name: ");
            string directorName = Console.ReadLine();

            Console.WriteLine("Enter actor name: ");
            string actorName = Console.ReadLine();

            Console.WriteLine("Enter genre: ");
            string genre = Console.ReadLine();
            array.Add(new Movie(name, actorName, genre, directorName));
            

            foreach (Movie x in array)
            {
                Console.WriteLine("Enter movie name name: " + x.NameofMovie);

                Console.WriteLine("Enter director name: " + x.Director);

                Console.WriteLine("Enter actor name: " + x.Actor);

                Console.WriteLine("Enter genre: " + x.Genre);
            }
        }
    }

}
    







