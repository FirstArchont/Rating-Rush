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
    internal class StarsDatabaseSpecification
    {
        [Test]
        public void FindCoincidence_ShouldReturnDefault_WhenCoincidenceDoseNotExist()
        {
            var database = new Dictionary<string, int>();
            var starsDatabase = new StarsDatabase(database);
            var result = starsDatabase.FindCoincidence("Поиск");
            Assert.That(result.Key, Is.EqualTo(null));
            Assert.That(result.Value, Is.EqualTo(0));
        }

        [Test]
        public void FindCoincidence_ShouldReturnKeyValuePair_WhenCoincidenceExists()
        {
            var database = new Dictionary<string, int>();
            database["Студия"] = 2;
            database["Режиссёр"] = 5;
            database["Актёр"] = 3;
            var starsDatabase = new StarsDatabase(database);
            var result = starsDatabase.FindCoincidence("Режиссёр");
            Assert.That(result.Key, Is.EqualTo("Режиссёр"));
            Assert.That(result.Value, Is.EqualTo(5));
        }
    }
}
