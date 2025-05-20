using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating_Rush.Domain
{
    public class Day
    {
        public int AmountOfMovies { get; }
        public int RatedMovies { get; set; }
        public List<Movie> Movies { get; set; }
        public TimeSpan TimeLeft { get; set; }
        public List<(string, Popularity)> GenresPopularity { get; } = new List<(string, Popularity)>();
        private static Random Random { get; } = new Random();

        public Day(int amountOfMovies, TimeSpan timeLeft, List<(string, Popularity)> genresPopularity, string title, string genre,
            string posterName, string country, int budget, int ageRate, Company company, Human director, Human mainActor, TimeSpan time)
        {
            AmountOfMovies = amountOfMovies;
            TimeLeft = timeLeft;
            RatedMovies = 0;
            GenresPopularity = genresPopularity;
            Movies = new List<Movie>();
            for (int i = 0; i < amountOfMovies; i++)
                Movies.Add(new Movie(new Rating(), title, genre, posterName, country, budget, ageRate, company, director, mainActor, time));
        }

        public Day(int amountOfMovies, TimeSpan time)
        {
            AmountOfMovies = amountOfMovies;
            TimeLeft = time;
            RatedMovies = 0;
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string generationDir = Path.Combine(solutionDir, "Rating Rush", "For Generation");
            var genres = File.ReadAllLines(Path.Combine(generationDir, "Genres.txt")).ToList();
            GenerateGenresPopularity(genres, (int) Math.Round((double) genres.Count / 100 * 20), Popularity.High);
            GenerateGenresPopularity(genres, (int)Math.Round((double)genres.Count / 100 * 44), Popularity.Medium);
            GenerateGenresPopularity(genres, genres.Count, Popularity.Low);
            Movies = new List<Movie>();
            for (int i = 0; i < amountOfMovies; i++)
                Movies.Add(new Movie(GenresPopularity));
        }

        private void GenerateGenresPopularity(List<string> genres, int amountOfGenres, Popularity popularity)
        {
            for (int i = 0; i < amountOfGenres; i++)
            {
                var index = Random.Next(genres.Count);
                GenresPopularity.Add((genres[index], popularity));
                genres.RemoveAt(index);
            }
        }
    }
}
