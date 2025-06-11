using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Rating_Rush.Domain
{
    public class Movie
    {
        public string Title { get; }
        public string PosterName { get; }
        public string Country { get; }
        public string Genre { get; }
        public int Budget { get; }
        public int AgeRate { get; }
        public Company Company { get; }
        public Human Director { get; }
        public Human MainActor { get; }
        public TimeSpan Time { get; }
        public Rating UsersRating { get; }
        private Popularity Quality { get; }
        private static Random Random { get; } = new Random();
        private const int ErrorRate = 0;
        private const int MatchChance = 75;

        public Movie(Rating usersRating, string title, string genre, string posterName, string country,
            int budget, int ageRate, Company company, Human director, Human mainActor, TimeSpan time)
        {
            UsersRating = usersRating;
            Title = title;
            Genre = genre;
            PosterName = posterName;
            Country = country;
            Budget = budget;
            AgeRate = ageRate;
            Company = company;
            Director = director;
            MainActor = mainActor;
            Time = time;
        }

        public Movie(List<(string, Popularity)> GenresPopularity)
        {
            Quality = (Popularity)Random.Next(3);
            UsersRating = new Rating(1);
            Title = GenerateTitle();
            var style = GenerateGenreAndPosterName(GenresPopularity);
            Genre = style.Item1;
            PosterName = style.Item2;
            UsersRating.Plot += UpdateUsersRating((int)GenresPopularity.First(pair => pair.Item1.Split()[0] == Genre).Item2, (int)Popularity.High, (int)Popularity.Low);
            Country = GenerateCountry();
            Budget = GenerateBudget();
            AgeRate = GenerateAgeRating();
            Company = new Company(Quality);
            UsersRating.Quality += UpdateUsersRating(Company.Stars, 4, 2);
            Director = new Human(Quality);
            UsersRating.Quality += UpdateUsersRating(Director.Stars, 4, 2);
            MainActor = new Human(Quality);
            UsersRating.Quality += UpdateUsersRating(MainActor.Stars, 4, 2);
            Time = GenerateTime();
        }

        private string GenerateCountry()
        {
            var countries = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "For Generation", "Countries.txt"));
            return countries[Random.Next(countries.Length)];
        }

        private (string, string) GenerateGenreAndPosterName(List<(string, Popularity)> GenresPopularity)
        {
            var genreChance = Random.Next(100);
            (string, Popularity) style = ("", Quality);
            var popularGenres = GenresPopularity.Where(genre => genre.Item2 == Popularity.High).ToList();
            var mediumGenres = GenresPopularity.Where(genre => genre.Item2 == Popularity.Medium).ToList();
            var badGenres = GenresPopularity.Where(genre => genre.Item2 == Popularity.Low).ToList();
            if (genreChance < MatchChance)
                style = SetStyle(badGenres, mediumGenres, popularGenres);
            else if (genreChance < MatchChance + (100 - MatchChance) / 2)
                style = SetStyle(popularGenres, badGenres, mediumGenres);
            else
                style = SetStyle(mediumGenres, popularGenres, badGenres);
            var posters = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "For Generation", "Posters", style.Item1.Split().Last()))
                .Where(file => file.EndsWith(".png", StringComparison.OrdinalIgnoreCase)).ToArray();
            return (style.Item1.Split().First(), posters[Random.Next(posters.Length)]);
        }

        private (string, Popularity) SetStyle(List<(string, Popularity)> firstCategory,
            List<(string, Popularity)> secondCategory, List<(string, Popularity)> thirdCategory)
        {
            (string, Popularity) style = ("", Quality);
            if (Quality == Popularity.Low)
                style = firstCategory[Random.Next(firstCategory.Count)];
            else if (Quality == Popularity.Medium)
                style = secondCategory[Random.Next(secondCategory.Count)];
            else
                style = thirdCategory[Random.Next(thirdCategory.Count)];
            return style;
        }

        private int UpdateUsersRating(int value, int maxValue, int minValue)
        {
            if (value >= maxValue)
                return (1 + Random.Next(-ErrorRate, ErrorRate + 1));
            else if (value <= minValue)
                return -(1 + Random.Next(-ErrorRate, ErrorRate + 1));
            return 0;
        }

        private TimeSpan GenerateTime()
        {
            int timeRange;
            if ((int)Quality == 0 || (int)Quality == 2)
            {
                int timeChance = Random.Next(100);
                if (timeChance < MatchChance / 2)
                    timeRange = Quality == Popularity.High ? 1 : 0;
                else if (timeChance < MatchChance)
                    timeRange = Quality == Popularity.High ? 2 : 3;
                else if (timeChance < (100 - MatchChance) / 2 + MatchChance)
                    timeRange = Quality == Popularity.High ? 0 : 1;
                else
                    timeRange = Quality == Popularity.High ? 3 : 2;
            }
            else
                timeRange = Random.Next(4);

            if (timeRange == 0)
            {
                UsersRating.Plot -= (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return TimeSpan.FromMinutes(Random.Next(30, 60));
            }
            else if (timeRange == 1)
            {
                UsersRating.Plot += (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return TimeSpan.FromMinutes(Random.Next(60, 120));
            }
            else if (timeRange == 2)
            {
                UsersRating.Plot += (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return TimeSpan.FromMinutes(Random.Next(120, 180));
            }
            else
            {
                UsersRating.Plot -= (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return TimeSpan.FromMinutes(Random.Next(180, 240));
            }
        }

        private int GenerateAgeRating()
        {
            int ageRange;
            if (Quality == Popularity.High || Quality == Popularity.Low)
            {
                int ageChance = Random.Next(100);
                if (ageChance < MatchChance / 2)
                    ageRange = Quality == Popularity.High ? 0 : 1;
                else if (ageChance < MatchChance)
                    ageRange = Quality == Popularity.High ? 3 : 2;
                else if (ageChance < (100 - MatchChance) / 2 + MatchChance)
                    ageRange = Quality == Popularity.High ? 1 : 0;
                else
                    ageRange = Quality == Popularity.High ? 2 : 3;
            }
            else
                ageRange = Random.Next(4);

            if (ageRange == 0)
            {
                UsersRating.Plot += (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return 0;
            }
            else if (ageRange == 1)
            {
                UsersRating.Plot -= (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return 6;
            }
            else if (ageRange == 2)
            {
                UsersRating.Plot -= (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return 12;
            }
            else
            {
                UsersRating.Plot += (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return 18;
            }
        }

        public const int LowestBudget = 100000;
        public const int IndieMovie = 500000;
        public const int BMovie = 20000000;
        public const int AMovie = 100000000;
        public const int LargesBudget = 500000000;

        private int GenerateBudget()
        {
            int budgetRange;
            if ((int)Quality == 0 || (int)Quality == 2)
            {
                int budgetChance = Random.Next(100);
                if (budgetChance < MatchChance / 2)
                    budgetRange = Quality == Popularity.High ? 0 : 1;
                else if (budgetChance < (100 - MatchChance) / 2 + MatchChance / 2)
                    budgetRange = Quality == Popularity.High ? 1 : 0;
                else if (budgetChance < (100 - MatchChance) / 2 + MatchChance)
                    budgetRange = Quality == Popularity.High ? 2 : 3;
                else
                    budgetRange = Quality == Popularity.High ? 3 : 2;
            }
            else
                budgetRange = Random.Next(4);

            if (budgetRange == 0)
            {
                UsersRating.Quality += (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return (int)(Math.Round(Random.Next(LowestBudget, IndieMovie) / 100000.0) * 100000);
            }
            else if (budgetRange == 1)
            {
                UsersRating.Quality -= (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return (int)(Math.Round(Random.Next(IndieMovie, BMovie) / 100000.0) * 100000);
            }
            else if (budgetRange == 2)
            {
                UsersRating.Quality += (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return (int)(Math.Round(Random.Next(BMovie, AMovie) / 100000.0) * 100000);
            }
            else
            {
                UsersRating.Quality -= (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return (int)(Math.Round(Random.Next(AMovie, LargesBudget) / 100000.0) * 100000);
            }
        }

        private string GenerateTitle()
        {
            var templates = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "For Generation", "Templates For Movie Name.txt"));
            var template = templates[Random.Next(templates.Length)];
            template = FillTemplate(template, SpeechPart.Noun.ToString());
            template = FillTemplate(template, SpeechPart.Verb.ToString());
            template = FillTemplate(template, SpeechPart.Adjective.ToString());
            if ((int)Quality == 2)
                template = AddNumberToTitleIfNecessary(template, (100 - MatchChance) / 2, 100 - MatchChance);
            else if ((int)Quality == 1)
                template = AddNumberToTitleIfNecessary(template, (100 - MatchChance) / 2, MatchChance + (100 - MatchChance) / 2);
            else
                template = AddNumberToTitleIfNecessary(template, MatchChance, MatchChance + (100 - MatchChance) / 2);
            return template[0].ToString().ToUpper() + template.Substring(1, template.Length - 1);
        }

        private string AddNumberToTitleIfNecessary(string template, int chanceOfBigNumber, int chanceOfSmallNumber)
        {
            var chanceOfHavingNumber = Random.Next(100);
            if (chanceOfHavingNumber < chanceOfBigNumber)
            {
                UsersRating.Plot -= (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return template = template.Substring(0, template.Length) + " " + Random.Next(34, 100).ToString();
            }
            else if (chanceOfHavingNumber > chanceOfSmallNumber)
            {
                UsersRating.Plot += (1 + Random.Next(-ErrorRate, ErrorRate + 1));
                return template = template.Substring(0, template.Length) + " " + Random.Next(2, 5).ToString();
            }
            return template;
        }

        private string FillTemplate(string template, string speechPart)
        {
            var speechParts = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "For Generation", speechPart + "s.txt"));
            speechPart = '[' + speechPart + "]";
            var changesAmount = (template.Length - template.Replace(speechPart, "").Length) / speechPart.Length;
            for (int i = 0; i < changesAmount; i++)
                template = ReplaceFirst(template, speechPart, speechParts[Random.Next(speechParts.Length)]);
            return template;
        }

        private string ReplaceFirst(string text, string oldText, string newText)
        {
            int index = text.IndexOf(oldText);
            return text.Substring(0, index) + newText + text.Substring(index + oldText.Length);
        }
    }
}