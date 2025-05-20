using NUnit.Framework;
using Rating_Rush.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    internal class CinemaAnalyticsSpecification
    {
        [Test]
        public void FindGenres_ShouldReturnEmptyList_WhenGenresDoesNotExist()
        {
            var day = new Day(3, TimeSpan.FromSeconds(1));
            day.GenresPopularity.Clear();
            day.GenresPopularity.Add(("Жанр", Popularity.Low));
            var cinemaAnalytics = new CinemaAnalytics(day);
            var result = cinemaAnalytics.FindGenres(Popularity.High);
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public void FindGenres_ShouldReturnGenres_WhenGenresExists()
        {
            var day = new Day(3, TimeSpan.FromSeconds(1));
            var cinemaAnalytics = new CinemaAnalytics(day);
            var result = cinemaAnalytics.FindGenres(Popularity.High);
            Assert.That(result.Count, Is.Not.EqualTo(0));
        }
    }
}
