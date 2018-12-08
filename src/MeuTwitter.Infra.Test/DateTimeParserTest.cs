using System;
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
            var createdDate = DateTime.Now.AddMinutes(-1);

            //Action
            string result = DateTimeParser.TryParce(createdDate);
            Debug.WriteLine("Passou no TEST");


            //Assert
            Assert.AreEqual("1 minuto atrás", result);
            Assert.IsTrue(true);
        }

        [Test]
        public void Infra_TwoMinute_Test()
        {
            //Arrenge
            var createdDate = DateTime.Now.AddMinutes(-1);

            //Action
            string result = DateTimeParser.TryParce(createdDate);
            Debug.WriteLine("Passou no TEST");


            //Assert
            Assert.AreEqual("2 minuto atrás", result);
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