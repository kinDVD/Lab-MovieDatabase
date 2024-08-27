using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MovieDatabase
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public static void ListMovies(List<Movie> movies)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i]}");
            }
        }

        public static void OrderByTitle(List<Movie> movies)
        {
            movies.OrderBy(x => x.Title).ToList();
        }
        public static void OrderByCategory(List<Movie> movies)
        {
            movies.OrderBy(x => x.Category).ToList();
        }


        /*public static List<string> GetBySelection(List<Movie> movies, string selection, List<string> selections)
        {
            foreach (Movie movie in movies)
            {
                if (movie.Category == selection)
                {
                    selections.Add(movie.Title);
                    return selections;
                }
                else if (movie.Title == selection)
                {
                    selections.Add(movie.Title);
                    return selections;
                }
                else if (int.TryParse(selection, out int id)) 
                {
                    
                    int s = int.Parse(selection) - 1;
                    
                    for (int i = 0; i <= movies.Count; i++)
                    {
                        if (movies[i].Title == selection)
                        {
                            selections.Add(movie.Title);
                            return selections;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                    return selections;   
                }
            }return selections;
        }

        public static void OrderBySelection(List<string> selections)
        {
            selections.Sort();
        }*/

    }
}
