using Lab_MovieDatabase;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
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
    //Movie.OrderByTitle(movies);
    //Movie.OrderByCategory(movies);
    foreach (Movie movie in movies)
    {
        int idx = movies.IndexOf(movie) + 1;
        Console.WriteLine($"{idx}. {movie.Title} - {movie.Category}");
    }
    Console.WriteLine();
    Console.WriteLine("You can select movie by number or title. Or, to filter by category, enter the category.");
    string selection = Console.ReadLine();

    List<string> catalog = new List<string>();
    int numS = 0;
    bool sInt = false;

    if (int.TryParse(selection, out int id))
    {
        numS = int.Parse(selection);
        sInt = true;
    }

    foreach (Movie movie in movies)
    {
        if (sInt == true)
        {
            int s = numS - 1;
            for (int i = 0; i <= movies.Count; i++)
            {
                if (s == movie.Title[i])
                {
                    catalog.Add(movie.Title);
                }
            }
        }
        else if (movie.Category == selection)
        {
            catalog.Add(movie.Title);
        }
        else if (movie.Title == selection)
        {
            catalog.Add(movie.Title);
            break;
        }
    }
    foreach (string c in catalog)
    {
        Console.WriteLine($"{c}");
    }

    /*Console.WriteLine($"Would you like to look at more movies? y/n");
    string again = Console.ReadLine().Trim().ToLower();
    if (again == "y")
    {
        result = true;
        Console.Clear();
    }
    else if (again == "n")
    {
        result = false;
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Try again");
    }
}

/*List<string> VHS = movies.Select(v => v.Title.ToString()).ToList();
foreach(string v in VHS)
{
    Console.WriteLine(v);
}

List<string> categories = movies.Select(m => m.Category.ToLower()).Distinct().ToList();
foreach(string category in categories)
{
    Console.WriteLine(category);
}


/*string goAgain = "yes";

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

} while (goAgain == "yes") ;*/
