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
    internal class CompanySpecification
    {
        [Test]
        public void CompanyShouldBeCreated()
        {
            var company = new Company(Popularity.Medium);
            var properties = company.GetType().GetProperties();
            foreach (var property in properties)
            {
                Assert.That(property.GetValue(company), Is.Not.Null);
                Assert.That(property.GetValue(company), Is.Not.Default);
            }
        }

        [Test]
        public void CompaniesShouldBeDifferent()
        {
            var company1 = new Company(Popularity.Medium);
            var company2 = new Company(Popularity.Medium);
            var properties1 = company1.GetType().GetProperties();
            var properties2 = company2.GetType().GetProperties();
            bool areMoviesDifferent = false;
            for (int i = 0; i < properties1.Length; i++)
            {
                if (properties1[i].GetValue(company1) != properties2[i].GetValue(company2))
                {
                    areMoviesDifferent = true;
                    break;
                }
            }
            Assert.That(areMoviesDifferent, Is.True);
        }

        [Test]
        public void HighQualityCompaniesShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.7;
            Assert.That(GetCompanyProbability(Popularity.High), Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        [Test]
        public void LowQualityCompaniesShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.7;
            Assert.That(GetCompanyProbability(Popularity.Low), Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        [Test]
        public void MediumQualityCompaniesShouldBeGeneratedWithCorrectProbability()
        {
            double expectedHighProbability = 0.7;
            Assert.That(GetCompanyProbability(Popularity.Medium), Is.EqualTo(expectedHighProbability).Within(0.05));
        }

        private double GetCompanyProbability(Popularity quality)
        {
            int highStarsCount = 0;
            int lowStarsCount = 0;
            int mediumStarsCount = 0;
            int totalAttempts = 1000;
            for (int i = 0; i < totalAttempts; i++)
            {
                var company = new Company(quality);
                if (company.Stars < 3)
                    lowStarsCount++;
                else if (company.Stars > 3)
                    highStarsCount++;
                else
                    mediumStarsCount++;
            }
            if (quality == Popularity.High)
                return (double)highStarsCount / totalAttempts;
            else if (quality == Popularity.Medium)
                return (double)mediumStarsCount / totalAttempts;
            else
                return (double)lowStarsCount / totalAttempts;
        }
    }
}
