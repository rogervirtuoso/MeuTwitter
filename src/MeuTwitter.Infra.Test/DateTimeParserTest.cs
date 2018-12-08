using System;
using NUnit.Framework;

namespace MeuTwitter.Infra.Test
{
    public class DateTimeParserTest
    {
        [Test]
        public void Infra_OneMinute_Test()
        {
            //Arrange
            var dataCriacao = DateTime.Now.AddMinutes(-1);

            //Action
            var result = DateTimeParser.TryParse(dataCriacao);

            //Assert
            Assert.IsTrue(result.Contains("1 minuto atrás"));
        }

        [Test]
        public void Infra_TwoMinute_Test()
        {
            //Arrange
            var dataCriacao = DateTime.Now.AddMinutes(-2);

            //Action
            var result = DateTimeParser.TryParse(dataCriacao);

            //Assert
            Assert.IsTrue(result.Contains("2 minutos atrás"));
        }

        [Test]
        public void Infra_OneHour_Test()
        {
            //Arrange
            var dataCriacao = DateTime.Now.AddHours(-1);

            //Action
            var result = DateTimeParser.TryParse(dataCriacao);

            //Assert
            Assert.IsTrue(result.Contains("1 hora atrás"));
        }

        [Test]
        public void Infra_TwoHour_Test()
        {
            //Arrange
            var dataCriacao = DateTime.Now.AddHours(-2);

            //Action
            var result = DateTimeParser.TryParse(dataCriacao);

            //Assert
            Assert.IsTrue(result.Contains("2 horas atrás"));
        }

        [Test]
        public void Infra_OneDay_Test()
        {
            //Arrange
            var dataCriacao = DateTime.Now.AddDays(-1);

            //Action
            var result = DateTimeParser.TryParse(dataCriacao);

            //Assert
            Assert.IsTrue(result.Contains("1 dia atrás"));
        }

        [Test]
        public void Infra_TwoDays_Test()
        {
            //Arrange
            var dataCriacao = DateTime.Now.AddDays(-2);

            //Action
            var result = DateTimeParser.TryParse(dataCriacao);

            //Assert
            Assert.IsTrue(result.Contains("2 dias atrás"));
        }

        [Test]
        public void Infra_TwoDaysFourHoursTenMinutes_Test()
        {
            //Arrange
            var dataCriacao = DateTime.Now.AddDays(-2);
            dataCriacao = dataCriacao.AddHours(-4);
            dataCriacao = dataCriacao.AddMinutes(-10);

            //Action
            var result = DateTimeParser.TryParse(dataCriacao);

            //Assert
            Assert.IsTrue(result.Contains("2 dias, 4 horas, 10 minutos atrás"));
        }

        [Test]
        public void Infra_OneDayOneHourOneMinute_Test()
        {
            //Arrange
            var dataCriacao = DateTime.Now.AddDays(-1);
            dataCriacao = dataCriacao.AddHours(-1);
            dataCriacao = dataCriacao.AddMinutes(-1);

            //Action
            var result = DateTimeParser.TryParse(dataCriacao);

            //Assert
            Assert.IsTrue(result.Contains("1 dia, 1 hora, 1 minuto atrás"));
        }

        [Test]
        public void Infra_InvalidDate_Test()
        {
            //Arrange
            var dataCriacao = DateTime.Now.AddDays(2);

            //Assert
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => DateTimeParser.TryParse(dataCriacao));
        }
    }
}