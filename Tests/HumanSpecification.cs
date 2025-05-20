using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rating_Rush.Domain;
using System.Security.Cryptography;
using Rating_Rush;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Tests
{
    [TestFixture]
    class HumanSpecification
    {
        public static void Main()
        {
        }

        [Test]
        public void HumanShouldBeCreated()
        {
            var human = new Human(Popularity.Medium);
            var properties = human.GetType().GetProperties();
            foreach (var property in properties)
            {
                Assert.That(property.GetValue(human), Is.Not.Null);
                Assert.That(property.GetValue(human), Is.Not.Default);
            }
        }

        [Test]
        public void HumansShouldBeDifferent()
        {
            var human1 = new Human(Popularity.Medium);
            var human2 = new Human(Popularity.Medium);
            var properties1 = human1.GetType().GetProperties();
            var properties2 = human2.GetType().GetProperties();
            bool areHumansDifferent = false;
            for (int i = 0; i < properties1.Length; i++)
            {
                if (properties1[i].GetValue(human1) != properties2[i].GetValue(human2))
                {
                    areHumansDifferent = true;
                    break;
                }
            }
            Assert.That(areHumansDifferent, Is.True);
        }

        [Test]
        public void HighQualityHumansShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.7;
            Assert.That(GetHumanProbability(Popularity.High), Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        [Test]
        public void LowQualityHumansShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.7;
            Assert.That(GetHumanProbability(Popularity.Low), Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        [Test]
        public void MediumQualityHumansShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.7;
            Assert.That(GetHumanProbability(Popularity.Medium), Is.EqualTo(expectedHighProbability).Within(0.05));
        }


        private double GetHumanProbability(Popularity quality)
        {
            int highStarsCount = 0;
            int lowStarsCount = 0;
            int mediumStarsCount = 0;
            int totalAttempts = 1000;
            for (int i = 0; i < totalAttempts; i++)
            {
                var company = new Human(quality);
                if (company.Stars < 3)
                    lowStarsCount++;
                else if (company.Stars > 3)
                    highStarsCount++;
                else
                    mediumStarsCount++;
            }
            if (quality == Popularity.High)
                return (double) highStarsCount / totalAttempts;
            else if (quality == Popularity.Medium)
                return (double) mediumStarsCount / totalAttempts;
            else
                return (double) lowStarsCount / totalAttempts;
        }
    }
}
