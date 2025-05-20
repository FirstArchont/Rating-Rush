using NUnit.Framework;
using Rating_Rush.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    internal class MovieSpecification
    {
        [Test]
        public void MovieShouldBeCreated()
        {
            var day = new Day(0, TimeSpan.FromSeconds(1));
            var movie = new Movie(day.GenresPopularity);
            var properties = movie.GetType().GetProperties();
            foreach (var property in properties)
            {
                Assert.That(property.GetValue(movie), Is.Not.Null);
                Assert.That(property.GetValue(movie), Is.Not.Default);
            }
        }

        [Test]
        public void MoviesShouldBeDifferent()
        {
            var day = new Day(5, TimeSpan.FromSeconds(1));
            var movie1 = new Movie(day.GenresPopularity);
            var movie2 = new Movie(day.GenresPopularity);
            var properties1 = movie1.GetType().GetProperties();
            var properties2 = movie2.GetType().GetProperties();
            bool areMoviesDifferent = false;
            for (int i = 0; i < properties1.Length; i++)
            {
                if (properties1[i].GetValue(movie1) != properties2[i].GetValue(movie2))
                {
                    areMoviesDifferent = true;
                    break;
                }
            }
            Assert.That(areMoviesDifferent, Is.True);
        }

        [Test]
        public void AllGenresHasPosters()
        {
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string generationDir = Path.Combine(solutionDir, "Rating Rush", "For Generation");
            var genres = File.ReadAllLines(Path.Combine(generationDir, "Genres.txt"))
                    .Select(line => line.Split().Last())
                    .ToList();
            string postersDir = Path.Combine(generationDir, "Posters");
            foreach (var genre in genres)
            {
                string genrePosterDir = Path.Combine(postersDir, genre);
                Assert.That(Directory.Exists(genrePosterDir), Is.True);
            }
        }

        [Test]
        public void MoviesTitleShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.33;
            var actualProbability = GetTitleProbability();
            Assert.That(actualProbability.Item1, Is.EqualTo(expectedHighProbability).Within(0.05));
            Assert.That(actualProbability.Item2, Is.EqualTo(expectedHighProbability).Within(0.05));
            Assert.That(actualProbability.Item3, Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        private (double, double, double) GetTitleProbability()
        {
            int goodTitlesCount = 0;
            int badTitlesCount = 0;
            int mediumTitlesCount = 0;
            int totalAttempts = 1000;
            var day = new Day(0, TimeSpan.FromSeconds(1));
            for (int i = 0; i < totalAttempts; i++)
            {
                var movie = new Movie(day.GenresPopularity);
                if (int.TryParse(movie.Title.Split().Last(), out _))
                {
                    if (int.Parse(movie.Title.Split().Last()) < 10)
                        goodTitlesCount++;
                    else
                        badTitlesCount++;
                }
                else
                    mediumTitlesCount++;
            }
            return ((double)goodTitlesCount / totalAttempts, (double)mediumTitlesCount / totalAttempts, (double)badTitlesCount / totalAttempts);
        }

        [Test]
        public void MoviesGenreShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.33;
            var actualProbability = GetGenreProbability();
            Assert.That(actualProbability.Item1, Is.EqualTo(expectedHighProbability).Within(0.05));
            Assert.That(actualProbability.Item2, Is.EqualTo(expectedHighProbability).Within(0.05));
            Assert.That(actualProbability.Item3, Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        private (double, double, double) GetGenreProbability()
        {
            int highPopularGenresCount = 0;
            int lowPopularGenresCount = 0;
            int mediumPopularTitlesCount = 0;
            int totalAttempts = 1000;
            var day = new Day(0, TimeSpan.FromSeconds(1));
            for (int i = 0; i < totalAttempts; i++)
            {
                var movie = new Movie(day.GenresPopularity);
                if (day.GenresPopularity.Any(style => style.Item1.Split()[0].Equals(movie.Genre, StringComparison.Ordinal) && style.Item2 == Popularity.Low))
                    lowPopularGenresCount++;
                else if (day.GenresPopularity.Any(style => style.Item1.Split()[0].Equals(movie.Genre, StringComparison.Ordinal) && style.Item2 == Popularity.High))
                    highPopularGenresCount++;
                else
                    mediumPopularTitlesCount++;
            }
            return ((double)highPopularGenresCount / totalAttempts, (double)mediumPopularTitlesCount / totalAttempts, (double)lowPopularGenresCount / totalAttempts);
        }

        [Test]
        public void MoviesBudgetShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.5;
            var actualProbability = GetBudgetProbability();
            Assert.That(actualProbability.Item1, Is.EqualTo(expectedHighProbability).Within(0.05));
            Assert.That(actualProbability.Item2, Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        private (double, double) GetBudgetProbability()
        {
            int goodBudgetCount = 0;
            int badBudgetCount = 0;
            int totalAttempts = 1000;
            var day = new Day(0, TimeSpan.FromSeconds(1));
            for (int i = 0; i < totalAttempts; i++)
            {
                var movie = new Movie(day.GenresPopularity);
                if (movie.Budget < Movie.IndieMovie)
                    goodBudgetCount++;
                else if (movie.Budget < Movie.BMovie)
                    badBudgetCount++;
                else if (movie.Budget < Movie.AMovie)
                    goodBudgetCount++;
                else
                    badBudgetCount++;
            }
            return ((double)goodBudgetCount / totalAttempts, (double)badBudgetCount / totalAttempts);
        }

        [Test]
        public void MoviesAgeRateShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.5;
            var actualProbability = GetAgeRateProbability();
            Assert.That(actualProbability.Item1, Is.EqualTo(expectedHighProbability).Within(0.05));
            Assert.That(actualProbability.Item2, Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        private (double, double) GetAgeRateProbability()
        {
            int goodBudgetCount = 0;
            int badBudgetCount = 0;
            int totalAttempts = 1000;
            var day = new Day(0, TimeSpan.FromSeconds(1));
            for (int i = 0; i < totalAttempts; i++)
            {
                var movie = new Movie(day.GenresPopularity);
                if (movie.AgeRate == 0)
                    goodBudgetCount++;
                else if (movie.AgeRate == 6)
                    badBudgetCount++;
                else if (movie.AgeRate == 12)
                    badBudgetCount++;
                else
                    goodBudgetCount++;
            }
            return ((double)goodBudgetCount / totalAttempts, (double)badBudgetCount / totalAttempts);
        }

        [Test]
        public void MoviesTimeShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.5;
            var actualProbability = GetTimeProbability();
            Assert.That(actualProbability.Item1, Is.EqualTo(expectedHighProbability).Within(0.05));
            Assert.That(actualProbability.Item2, Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        private (double, double) GetTimeProbability()
        {
            int goodTimeCount = 0;
            int badTimeCount = 0;
            int totalAttempts = 1000;
            var day = new Day(0, TimeSpan.FromSeconds(1));
            for (int i = 0; i < totalAttempts; i++)
            {
                var movie = new Movie(day.GenresPopularity);
                if (movie.Time < TimeSpan.FromMinutes(60))
                    badTimeCount++;
                else if (movie.Time < TimeSpan.FromMinutes(120))
                    goodTimeCount++;
                else if (movie.Time < TimeSpan.FromMinutes(180))
                    goodTimeCount++;
                else
                    badTimeCount++;
            }
            return ((double)goodTimeCount / totalAttempts, (double)badTimeCount / totalAttempts);
        }

        [Test]
        public void MoviesShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.25;
            var actualProbability = GetMovieProbability();
            Assert.That(actualProbability.Item1, Is.EqualTo(expectedHighProbability).Within(0.05));
            Assert.That(actualProbability.Item2, Is.EqualTo(1 - expectedHighProbability * 2).Within(0.05));
            Assert.That(actualProbability.Item3, Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        private (double, double, double) GetMovieProbability()
        {
            int highRatingCount = 0;
            int lowRatingCount = 0;
            int mediumRatingCount = 0;
            int totalAttempts = 1000;
            var day = new Day(0, TimeSpan.FromSeconds(1));
            for (int i = 0; i < totalAttempts; i++)
            {
                var company = new Movie(day.GenresPopularity);
                if (company.UsersRating.TotalRating < 35)
                    lowRatingCount++;
                else if (company.UsersRating.TotalRating > 65)
                    highRatingCount++;
                else
                    mediumRatingCount++;
            }
            return ((double)highRatingCount / totalAttempts, (double)mediumRatingCount / totalAttempts, (double)lowRatingCount / totalAttempts);
        }
    }
}
