using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Unit4_MovieDatabase;

List<Movies> movies = new List<Movies>()
{
    new Movies() { Title = "The Godfather", Category = "Drama" },
    new Movies() { Title = "The Shawshank Redemption", Category = "Drama" },
    new Movies() { Title = "Pulp Fiction", Category = "Drama" },
    new Movies() { Title = "The Dark Knight", Category = "Action" },
    new Movies() { Title = "The Silence of the Lambs", Category = "Thriller" },
    new Movies() { Title = "Forrest Gump", Category = "Drama" },
    new Movies() { Title = "Goodfellas", Category = "Drama" },
    new Movies() { Title = "Jurrasic Park", Category = "Sci-Fi" },
    new Movies() { Title = "The Lord of the Rings", Category = "Fantasy" },
    new Movies() { Title = "The Matrix", Category = "Sci-Fi" },
    new Movies() { Title = "A Star is Born", Category = "Musical" },
    new Movies() { Title = "Black Panther", Category = "Action" },
    new Movies() { Title = "The Exorcist", Category = "Horror" },
    new Movies() { Title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe", Category = "Fantasy" },
    new Movies() { Title = "Labyrinth", Category = "Fantasy" },
    new Movies() { Title = "The Wizard of Oz", Category = "Fantasy" },
    new Movies() { Title = "The Terminator", Category = "Sci-Fi" },
    new Movies() { Title = "War of the Worlds", Category = "Sci-Fi" },
    new Movies() { Title = "A Nightmare on Elm Street", Category = "Horror" },
    new Movies() { Title = "Phantom of the Opera", Category = "Musical" },
    new Movies() { Title = "Singin' in the Rain", Category = "Musical" },
    new Movies() { Title = "Untraceable", Category = "Thriller" },
    new Movies() { Title = "Die Hard", Category= "Action" },
};

List<Menu> categories = new List<Menu>()
{
    new Menu() { Number = 1, Category = "Drama"},
    new Menu() { Number = 2, Category = "Action"},
    new Menu() { Number = 3, Category = "Thriller"},
    new Menu() { Number = 4, Category = "Sci-Fi"},
    new Menu() { Number = 5, Category = "Fantasy"},
    new Menu() { Number = 6, Category = "Musical"},
    new Menu() { Number = 7, Category = "Horror"},
};

Console.WriteLine("Welcome to the Movie List Application!" + "\n");
Console.WriteLine("There are " + movies.Count + " movies in this list.");


do
{
    Console.WriteLine("What category are you interested in?");
    foreach (Menu menuNumber in categories)
    {
        Console.WriteLine($"{menuNumber.Category}"+ " ");
    }
    Console.WriteLine("\n");

    string userInput = Console.ReadLine();
    bool isValid = false;
    foreach (Movies film in movies)
    {
        
        if (film.Category == userInput)
        {
            isValid = true;
            Console.WriteLine($"{film.Title}");
        }
    }
    if (isValid == false)
    {
        Console.WriteLine("Category is not a valid choice.");
    }
   
    Console.WriteLine("Continue?");
} while (Console.ReadLine() == "y");

Console.WriteLine("Goodbye!");