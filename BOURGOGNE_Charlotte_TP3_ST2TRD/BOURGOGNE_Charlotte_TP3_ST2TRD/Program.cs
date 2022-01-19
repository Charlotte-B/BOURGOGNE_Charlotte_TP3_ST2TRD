using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;  

using TP3;

namespace BOURGOGNE_Charlotte_TP3_ST2TRD
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Movie = new MovieCollection().Movies;

            // Builder pattern
            var oldestFilm = Movie.OrderBy(movies => movies.ReleaseDate).First().Title;
            Console.WriteLine(oldestFilm);
            
            // Count all movies.
            var numberOfFilm = Movie.Count();
            Console.WriteLine(numberOfFilm);
            
            //Count all movies with the letter e. at least once in the title
            var eLetterPresent = Movie.Where(movies => movies.Title.Contains("e")).Count();
            Console.WriteLine(eLetterPresent);
            
            //Count how many time the letter f is in all the titles from this list.
            //88
            int counter = 0;

            foreach (var film in Movie)
            {
               counter = film.Title.Count(movies => movies == 'f');
            }
            Console.WriteLine(counter);
            
            // Display the title of the film with the higher budget.
            var higherBudget = Movie.OrderBy(movies => movies.Budget).First().Title;
            Console.WriteLine(higherBudget);
            
            // Display the title of the movie with the lowest box office.
            var lowestBoxOffice = Movie.OrderBy(movies => movies.BoxOffice).Last().Title;
            Console.WriteLine(lowestBoxOffice);
            
            // Order the movies by reversed alphabetical order and print the first 11 of the list.
            var alphabeticalOrder = Movie.OrderBy(movies => movies.Title).First().Title;
            Console.WriteLine(alphabeticalOrder);
            
            /*
            //Count all the movies made before 1980.
            int counterMovie = 0;

            foreach (var moviesMadeBefore in Movie)
            {
                counterMovie = moviesMadeBefore.ReleaseDate.Count(movies => movies <= 1980);
            }
            Console.WriteLine(counterMovie);
            */

            
            //Exercise 2
            Threads.Action();

        }

    }

}



