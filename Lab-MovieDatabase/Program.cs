using Lab_MovieDatabase;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Welcome to the Movie List!");

List <Movie> movies = new List<Movie> 
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
string goAgain = "yes";
do 
{ 
    List<string> filmshelf = new List<string>();
    Movie.OrderByTitle(movies, filmshelf);
    Console.WriteLine($"There are {movies.Count} available.");

    foreach(var m in filmshelf)
    {
        int idx = filmshelf.IndexOf(m) + 1;
        Console.WriteLine($"{idx}. {m}");
    }
    string input = "";

    while (true)
    {
        Console.WriteLine("What are you looking for? (Enter the film Title, Genre, or number.)");
        string choice = Console.ReadLine().ToLower().Trim();

        int shelves = filmshelf.Count();
        if (choice == "horror" ^ choice == "fantasy" ^ choice == "comedy" ^ choice == "romance" ^ choice == "drama" ^ choice == "international" ^ choice == "animated")
        {
            input = choice;
            break;
        }
        else if (filmshelf.Contains(choice))
        {
            input = choice;
            break;
        }
        else if ((int.TryParse(choice, out int num)) && num <= shelves)
        {
            input = choice;
            break;
        }
        else if ((int.TryParse(choice, out int nut)) && nut < 0 ^ nut > shelves)
        {
            Console.WriteLine("Please enter a valid number.");
            continue;

        }
        else if (!filmshelf.Contains(choice))
        {
            Console.WriteLine("That is not available. Please enter a valid option.");
            continue;
        }

    }
    string selection = input;

    List<string> selections = new List<string>(); 
    Movie.GetBySelection(movies, selection, selections);
    Movie.OrderBySelection(selections);
    Console.WriteLine($"You have selected");

    foreach (var f in selections)
    {
        int ix = selections.IndexOf(f) + 1;
        Console.WriteLine($"{ix}. {f}");
    }
Console.WriteLine("Would you like to go again?");
goAgain = Console.ReadLine().ToLower().Trim();
if (goAgain == "yes")
{
    continue;
}
else if (goAgain == "no")
{
    goAgain = "no";
    break;
}
else
{
    Console.WriteLine("Please enter yes or no.");
}

} while (goAgain == "yes") ;
