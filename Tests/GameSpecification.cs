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
    internal class GameSpecification
    {
        [Test]
        public void GameShouldBeCreated()
        {
            var game = new Game(1);
            var properties = game.GetType().GetProperties();
            foreach (var property in properties)
            {
                Assert.That(property.GetValue(game), Is.Not.Null);
                Assert.That(property.GetValue(game), Is.Not.Default);
            }
        }

        [Test]
        public void ScenariosShouldBeDifferent()
        {
            var game1 = new Game(1);
            var game2 = new Game(1);
            var day1 = game1.Days.First();
            var day2 = game2.Days.First();
            var properties1 = day1.GetType().GetProperties();
            var properties2 = day2.GetType().GetProperties();
            bool areHumansDifferent = false;
            for (int i = 0; i < properties1.Length; i++)
            {
                if (properties1[i].GetValue(day1) != properties2[i].GetValue(day2))
                {
                    areHumansDifferent = true;
                    break;
                }
            }
            Assert.That(areHumansDifferent, Is.True);
        }

        [Test]
        public void EndTheDay_ShouldWorkCorrect_WhenItIsNotLastDay()
        {
            var game = new Game(1);
            var player = new Player();
            game.EndTheDay();
            Assert.That(game.Days.Count, Is.EqualTo(6));
            Assert.That(game.AmountOfPassedDays, Is.EqualTo(1));
        }

        [Test]
        public void EndTheDay_ShouldNotReduceDays_WhenItIsLastDay()
        {
            var game = new Game(1);
            var player = new Player();
            for (int i = 0; i < game.AmountOfDays; i++)
                game.EndTheDay();
            game.EndTheDay();
            Assert.That(game.Days.Count, Is.EqualTo(0));
            Assert.That(game.AmountOfPassedDays, Is.EqualTo(7));
        }

        [Test]
        public void HasGameEnded_ShouldReturnTrue_WhenThereIsNoMoreDays()
        {
            var game = new Game(1);
            for (int i = 0; i < game.AmountOfDays; i++)
                game.EndTheDay();
            Assert.That(game.IsGameEnded(), Is.True);
        }

        [Test]
        public void HasGameEnded_ShouldReturnFalse_WhenThereIsMoreDays()
        {
            var game = new Game(1);
            Assert.That(game.IsGameEnded(), Is.False);
        }
    }
}
