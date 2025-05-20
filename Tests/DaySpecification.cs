using NUnit.Framework;
using Rating_Rush.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    internal class DaySpecification
    {
        [Test]
        public void DayShouldBeCreated()
        {
            var day = new Day(3, TimeSpan.FromMinutes(5));
            var properties = day.GetType().GetProperties();
            foreach (var property in properties)
            {
                Assert.That(property.GetValue(day), Is.Not.Null);
                Assert.That(property.GetValue(day), Is.Not.Default);
            }
        }

        [Test]
        public void DaysShouldHaveDifferentGenresPopularity()
        {
            var day1 = new Day(3, TimeSpan.FromMinutes(5));
            var day2 = new Day(5, TimeSpan.FromMinutes(3));
            bool areGenresPopularityDifferent = false;
            for (int i = 0; i < day1.GenresPopularity.Count; i++)
            {
                if (day1.GenresPopularity[i] != day2.GenresPopularity[i])
                    areGenresPopularityDifferent = true;
            }
            Assert.That(areGenresPopularityDifferent, Is.True);
        }

        [Test]
        public void GenresPopularityShouldBeGeneratedInCorrectAmounts()
        {
            var day = new Day(3, TimeSpan.FromMinutes(5));
            var highPopularGenres = day.GenresPopularity.Where(pair => pair.Item2 == Popularity.High).Count();
            var mediumPopularGenres = day.GenresPopularity.Where(pair => pair.Item2 == Popularity.Medium).Count();
            var lowPopularGenres = day.GenresPopularity.Where(pair => pair.Item2 == Popularity.Low).Count();
            Assert.That(highPopularGenres, Is.EqualTo(Math.Round((double) day.GenresPopularity.Count() / 100 * 20)).Within(1));
            Assert.That(mediumPopularGenres, Is.EqualTo(Math.Round((double) day.GenresPopularity.Count() / 100 * 30)).Within(1));
            Assert.That(lowPopularGenres, Is.EqualTo(Math.Round((double) day.GenresPopularity.Count() / 100 * 50)).Within(1));
        }
    }
}
