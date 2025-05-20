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
    internal class RatingsComparerSpecification
    {
        [Test]
        public void ShouldReturnMaxReward_WhenPlayerRatingIsPerfect()
        {
            var player = new Player();
            var reward = RatingsComparer.CompareRatings(new Rating(), new Rating(), player.Fame, 20);
            Assert.That(reward.Fame, Is.EqualTo(RatingsComparer.FameReward));
            Assert.That(reward.Money, Is.EqualTo(20 + 20 / 2 * 2));
            player.Fame += reward.Fame;
            player.Money += reward.Money;
            Assert.That(player.Fame, Is.EqualTo(RatingsComparer.FameReward));
            Assert.That(player.Money, Is.EqualTo(20 + 20 / 2 * 2));
        }

        [Test]
        public void ShouldNotGiveMoney_WhenPlayerRatingIsWorse()
        {
            var player = new Player();
            var playerRating = new Rating();
            var usersRating = new Rating();
            usersRating.Plot = 0;
            usersRating.Quality = 0;
            var reward = RatingsComparer.CompareRatings(playerRating, usersRating, player.Fame, 20);
            Assert.That(reward.Fame, Is.EqualTo(-RatingsComparer.FameReward));
            Assert.That(reward.Money, Is.EqualTo(0));
            player.Fame += reward.Fame;
            player.Money += reward.Money;
            Assert.That(player.Fame, Is.EqualTo(-RatingsComparer.FameReward));
            Assert.That(player.Money, Is.EqualTo(0));
        }

        [Test]
        public void ShouldReturnCorrectReward_WhenPlayerRatingIsNormal()
        {
            var player = new Player();
            player.Fame = 50;
            var playerRating = new Rating();
            var usersRating = new Rating();
            usersRating.Plot = 3;
            usersRating.Quality = 8;
            playerRating.Plot = 3;
            playerRating.Quality = 7;
            var reward = RatingsComparer.CompareRatings(playerRating, usersRating, player.Fame, 20);
            Assert.That(reward.Fame, Is.EqualTo(RatingsComparer.FameReward));
            Assert.That(reward.Money, Is.EqualTo((int)Math.Round(((20 + 20 / 2 + 20 / 2 / 2) * ((double)player.Fame / 100 + 1)))));
        }

        [Test]
        public void ShouldReturnCorrectReward_WhenPlayerRatingIsNotFair()
        {
            var player = new Player();
            player.Fame = -50;
            var playerRating = new Rating();
            var usersRating = new Rating();
            usersRating.Plot = 3;
            usersRating.Quality = 8;
            playerRating.Plot = 7;
            playerRating.Quality = 2;
            var reward = RatingsComparer.CompareRatings(playerRating, usersRating, player.Fame, 20);
            Assert.That(reward.Fame, Is.EqualTo(0));
            Assert.That(reward.Money, Is.EqualTo((int)Math.Round((20 / 2 * ((double)player.Fame / 100 + 1)))));
        }
    }
}
