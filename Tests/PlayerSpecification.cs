using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rating_Rush.Domain;

namespace Tests
{
    [TestFixture]
    class PlayerSpecification
    {
        [Test]
        public void PlayerShouldLose_WhenMoneyIsGone()
        {
            var player = new Player();
            player.Money = -1;
            Assert.That(player.HasPlayerLostDueToMoney(), Is.EqualTo(true));
            Assert.That(player.HasPlayerLostDueToFame(), Is.EqualTo(false));
        }

        [Test]
        public void PlayerShouldLose_WhenFameIsWorst()
        {
            var player = new Player();
            player.Fame = -100;
            Assert.That(player.HasPlayerLostDueToFame(), Is.EqualTo(true));
            Assert.That(player.HasPlayerLostDueToMoney(), Is.EqualTo(false));
        }

        [Test]
        public void PlayerShouldNotLose_WhenHeHasMoneyAndFame()
        {
            var player = new Player();
            Assert.That(player.HasPlayerLostDueToFame(), Is.EqualTo(false));
            Assert.That(player.HasPlayerLostDueToMoney(), Is.EqualTo(false));
        }

        [Test]
        public void PlayerShouldNotGainMoreThanBestFame()
        {
            var player = new Player();
            player.Fame = Player.BestFame;
            player.Fame += 10;
            Assert.That(player.Fame, Is.EqualTo(Player.BestFame));
        }

        [Test]
        public void PlayerShouldNotGainLessThanWorstFame()
        {
            var player = new Player();
            player.Fame = Player.WorstFame;
            player.Fame -= 10;
            Assert.That(player.Fame, Is.EqualTo(Player.WorstFame));
        }

        [Test]
        public void CountTaxes_Should_WorkCorrect()
        {
            var currentPlayer = new Player();
            var standardPlayer = new Player();
            var currentScenario = new Scenario(1);
            var standardScenario = new Scenario(1);
            currentPlayer.CountTaxes(currentScenario);
            Assert.That(currentPlayer.Money, Is.EqualTo(standardPlayer.Money - standardScenario.Tax));
            Assert.That(currentScenario.Tax, Is.EqualTo(standardScenario.Tax + standardScenario.TaxDifference));
        }

        [Test]
        public void CountIncome_Should_WorkCorrect()
        {
            var currentPlayer = new Player();
            var standardPlayer = new Player();
            var scenario = new Scenario(1);
            var results = RatingsComparer.CompareRatings(new Rating(), new Rating(), currentPlayer.Fame, scenario.MaxReward);
            currentPlayer.CountIncome(results);
            Assert.That(currentPlayer.Money, Is.EqualTo(standardPlayer.Money + scenario.MaxReward * 2));
            Assert.That(currentPlayer.Fame, Is.EqualTo(standardPlayer.Fame + RatingsComparer.FameReward));
        }
    }
}
