using System.Linq;

namespace Linq_Brown_jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // makes an array of games
            Game[] games = new Game[]
            {
            new Game("valorant", 'T', "fps"),
            new Game("GGST", 'T', "fighting"),
            new Game("SF6", 'T', "fighting"),
            new Game("Game1", 'M', "fps"),
            new Game("Game2", 'E', "RPG"),
            new Game("Game3", 'T', "Action"),
            new Game("Game4", 'E', "fps"),
            new Game("Game5", 'M', "RPG"),
            new Game("Game6", 'E', "Action"),
            new Game("Game7", 'M', "fighting"),
            };

            // Filters and display games with titles shorter than 5 characters, in uppercase
            var shortGames = from game in games
                             where game.Title.Length < 5
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach (var game in shortGames)
            {
                Console.WriteLine(game);
            }

            // Finds and displays information for valorant
            var valorant = games
                .Where(game => game.Title == "valorant")
                .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

            Console.WriteLine(valorant.FirstOrDefault());

            // Filters and displays titles of all games rated T
            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            Console.WriteLine("T rated games:");
            foreach (var game in tRated)
            {
                Console.WriteLine(game);
            }

            // Filters and displays titles of all games rated E and that are action games
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            Console.WriteLine("E rated action games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }

}