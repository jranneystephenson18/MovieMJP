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
        System.IO.StreamReader File = new System.IO.StreamReader(@"C:\Users\User\test.txt");
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
        }      
    }
}


