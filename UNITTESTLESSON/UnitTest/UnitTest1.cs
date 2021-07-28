using NUnit.Framework;
using CODETOTEST;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GiveATimeOf21_Greeting_ReturnsGoodEvening()
        {
            var time = 21;
            var expectedGreeting = "Good evening!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GiveATimeOf7_Greeting_ReturnsGoodMorning()
        {
            var time = 7;
            var expectedGreeting = "Good morning!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GiveATimeOf15_Greeting_ReturnsGoodAfternoon()
        {
            var time = 15;
            var expectedGreeting = "Good afternoon!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [Test]
        public void GivenATimeof12_Greeting_ReturnsGoodMorning()
        {
            var time = 12;
            var expectedGreeting = "Good morning!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(11)]
        [TestCase(7)]
        [TestCase(5)]
        public void GivenATimeBetween5and12_Greeting_ReturnsGoodMorning(int time)
        {
            var expectedGreeting = "Good morning!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(13)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenATimeBetween12and18_Greeting_ReturnsGoodMorning(int time)
        {
            var expectedGreeting = "Good afternoon!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(19)]
        [TestCase(23)]
        [TestCase(3)]
        public void GivenATimeBetween19and4_Greeting_ReturnsGoodMorning(int time)
        {
            var expectedGreeting = "Good evening!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}