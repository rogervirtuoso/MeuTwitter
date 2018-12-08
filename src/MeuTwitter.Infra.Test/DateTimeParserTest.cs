using System.Diagnostics;
using NUnit.Framework;

namespace MeuTwitter.Infra.Test
{
    public class DateTimeParserTest
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Debug.WriteLine("Passou no ONETIMESETUP");
        }

        [SetUp]
        public void Setup()
        {
            Debug.WriteLine("Passou no SETUP");
        }

        [Test]
        public void Infra_OneMinute_Test()
        {
            //Arrenge

            //Action
            Debug.WriteLine("Passou no TEST");

            //Assert

            Assert.IsTrue(true);
        }

        [TearDown]
        public void TearDown()
        {
            Debug.WriteLine("Passou no TEARDOWN");
        }

        [OneTimeTearDown]
        public void OneTearDown()
        {
            Debug.WriteLine("Passou no ONETIMETEARDOWN");
        }
    }
}