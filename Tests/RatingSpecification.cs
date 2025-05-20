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
    internal class RatingSpecification
    {
        [Test]
        public void BasicRating_WithoutErrorRate_ShouldBeEqualTo50()
        {
            var rating = new Rating();
            Assert.That(rating.TotalRating, Is.EqualTo(50));
        }

        [Test]
        public void BasicRating_WithoutErrorRate_ShouldBeMultipleOf5()
        {
            var random = new Random();
            var rating = new Rating();
            rating.Quality = random.Next(11);
            rating.Plot = random.Next(11);
            Assert.That(rating.TotalRating % 5, Is.EqualTo(0));
        }

        [Test]
        public void BasicRating_WithoutErrorRate_ShouldBeCountedRight()
        {
            var rating = new Rating();
            var random = new Random();
            rating.Plot = random.Next(11);
            rating.Quality = random.Next(11);
            Assert.That(rating.TotalRating, Is.EqualTo((rating.Plot + rating.Quality) * 10 /2));
        }

        [Test]
        public void PlotAndQualityRatingShouldNotBeLesserThanMinRating()
        {
            var rating = new Rating();
            rating.Plot = 0;
            rating.Quality = 0;
            rating.Plot -= 1;
            rating.Quality -= 1;
            Assert.That(rating.Plot, Is.EqualTo(Rating.MinRating));
            Assert.That(rating.Quality, Is.EqualTo(Rating.MinRating));
        }

        [Test]
        public void PlotAndQualityRatingShouldNotBeBiggerThanMaxRating()
        {
            var rating = new Rating();
            rating.Plot = 10;
            rating.Quality = 10;
            rating.Plot += 1;
            rating.Quality += 1;
            Assert.That(rating.Plot, Is.EqualTo(Rating.MaxRating));
            Assert.That(rating.Quality, Is.EqualTo(Rating.MaxRating));
        }
    }
}
