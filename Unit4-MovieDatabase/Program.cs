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

List<Categories> categories = new List<Categories>()
{
    new Categories() { Category = "Drama"},
    new Categories() { Category = "Action"},
    new Categories() { Category = "Thriller"},
    new Categories() { Category = "Sci-Fi"},
    new Categories() { Category = "Fantasy"},
    new Categories() { Category = "Musical"},
    new Categories() { Category = "Horror"},
};

Console.WriteLine("Welcome to the Movie List Application!" + "\n");
Console.WriteLine("There are " + movies.Count + " movies in this list.");

do
{
    Console.WriteLine("What category are you interested in?");
    foreach (Categories category in categories)
    {
        Console.Write($"{category.Category}"+ " ");
    }
    Console.WriteLine("\n");

    string userInput = Console.ReadLine();
 
    foreach (Movies film in movies)
    {
        if (film.Category == userInput)
        {
            Console.WriteLine($"{film.Title}");
        }
    }

    Console.WriteLine("Continue?");
} while (Console.ReadLine() == "y");


Console.WriteLine("Goodbye!");