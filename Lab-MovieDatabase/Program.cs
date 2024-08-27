using Lab_MovieDatabase;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;


    Console.WriteLine("Welcome to the Movie List!");

    List<Movie> movies = new List<Movie>
{
    new Movie("Star Wars", "fantasy"),
    new Movie("Nope", "horror"),
    new Movie("Galaxy Quest", "comedy"),
    new Movie("Prometheus", "horror"),
    new Movie("Eternal Sunshine of the Spotless Mind", "romance"),
    new Movie("Martian", "drama"),
    new Movie("Shin Godzilla", "international"),
    new Movie("Akira", "animated"),
    new Movie("The Host", "international"),
    new Movie("Titan AE", "animated"),
    new Movie("Okja", "drama"),
    new Movie("The Fountain", "romance"),
    new Movie("Spaceballs", "comedy"),
    new Movie("The Fifth Element", "fantasy"),
    new Movie("Stargate", "fantasy"),
    new Movie("Event Horizon", "horror"),
    new Movie("Hitchhiker's Guide to the Galaxy", "comedy"),
    new Movie("Annihilation", "horror"),
    new Movie("Starman", "romance"),
    new Movie("Contact", "drama"),
    new Movie("The Wandering Earth", "international"),
    new Movie("Fantastic Planet", "animated")
};

//Movie.ListMovies(movies);
//Movie.OrderByTitle(movies);
//Movie.OrderByCategory(movies);
int i = 1;
List<string> categories = movies.DistinctBy(m => m.Category).Select(m => m.Category).ToList();
foreach (string cat in categories)
{
    Console.WriteLine($"{i++}. {cat}");
}

Console.WriteLine("\nYou can select movie by number or category.");
string selection = Console.ReadLine();

int numS = 0;
if (int.TryParse(selection, out numS))
{
    numS--;
    selection = categories[numS];
}
movies.Where(m => m.Category == selection).ToList().ForEach(m => Console.WriteLine(m.Title));



//foreach (Movie movie in movies)
//{
    //if (sInt == true)
    //{
    //    int s = numS - 1;
    //    for (int i = 0; i <= movies.Count; i++)
    //    {
    //        if (s == movie.Title[i])
    //        {
    //            catalog.Add(movie.Title);
    //        }
    //    }
    //}
//    if (movie.Category == selection)
//    {
//        catalog.Add(movie.Title);
//    }
//    else if (movie.Title == selection)
//    {
//        catalog.Add(movie.Title);
//        break;
//    }
//}
//foreach (string c in catalog)
//{
//    Console.WriteLine($"{c}");
//}
