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

namespace WorkingTests
{
    [TestFixture]
    class HumanSpecification
    {
        [Test]
        public void HumanShouldBeCreated()
        {
            var human = new Human();
            Assert.That(2, Is.EqualTo(human.Name.Split().ToArray().Length));
            Assert.That(default(int), !Is.EqualTo(human.Stars));
        }

        [Test]
        public void HumansShouldBeDifferent()
        {
            var human1 = new Human();
            var human2 = new Human();
            Assert.That(human1.Name, !Is.EqualTo(human2.Name));
        }
    }
}