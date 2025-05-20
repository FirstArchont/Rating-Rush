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
    internal class ScenarioSpecification
    {
        [Test]
        public void ScenarioShouldBeCreated()
        {
            var scenario = new Scenario(Scenario.EasyScenario);
            var properties = scenario.GetType().GetProperties();
            foreach (var property in properties)
                Assert.That(property.GetValue(scenario), Is.Not.Null);
        }

        [Test]
        public void ScenariosShouldBeDifferent()
        {
            var scenario1 = new Scenario(Scenario.EasyScenario);
            var scenario2 = new Scenario(Scenario.EasyScenario);
            var day1 = scenario1.Days.First();
            var day2 = scenario2.Days.First();
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
    }
}
