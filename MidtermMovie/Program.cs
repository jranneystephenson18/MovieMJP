using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermMovie
{
    class Program
    {
        static void Main(string[] args)
        {
        int counter = 0;

        string[] details;
        List<Movie> movieDetail = new List<Movie>();
        // Read the file and display it line by line.  
        System.IO.StreamReader File = new System.IO.StreamReader(@"C:\Users\vkat9\Documents\Visual Studio 2017\test.txt");
         while (!File.EndOfStream)
            {
                var line = File.ReadLine();
                string[] words = line.Split(',');
                movieDetail.Add(new Movie(words[0],words[1],words[2],words[3]));
                System.Console.WriteLine(line);
           //     Console.WriteLine(" {0} + {1} ", words[0], words[1]);
           //     counter++;
            }

         File.Close();
            int input;
            do
            {
                input = 0;
                Console.WriteLine("Choose any one option.....");
                Console.WriteLine("1. Find a movie");
                Console.WriteLine("2. Find movie by actor");
                Console.WriteLine("3. Find a movie by director");
                Console.WriteLine("4. Add a new movie");
                Console.WriteLine("5. Quit Program");

                string inputstring = Console.ReadLine();
                bool iscorrectiput = int.TryParse(inputstring, out input);

                while (!iscorrectiput && input < 6 && input > 0)
                {
                    Console.WriteLine("Invalid option, Please try again");
                    iscorrectiput = int.TryParse(inputstring, out input);
                }

                Movie searchedmovie;
                switch (input)
                {
                    case 1:
                        searchedmovie = mvoies.FindMovie();
                        mvoies.DisplayMovie(searchedmovie);
                        break;

                    case 2:
                        searchedmovie = mvoies.FindMovieByActor();
                        mvoies.DisplayMovie(searchedmovie);
                        break;

                    case 3:
                        searchedmovie = mvoies.FindMovieByDirector();
                        mvoies.DisplayMovie(searchedmovie);
                        break;

                    case 4:
                        mvoies.AddMovie();

                        break;

                    case 5:
                        Console.WriteLine("The program is ended..");
                        break;
                }

                Console.WriteLine("=============================================================");
            } while (input != 5);
        }
    }
}      
    }
}


