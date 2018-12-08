using System;
using NUnit.Framework;

namespace MeuTwitter.Domain.Test
{
    public class DateTimeParserTest
    {
        [Test]
        public void Domain_Valid_Message_Post_Test()
        {
            //Arrange
            var post = new Post();
            post.SetMessage("Hello World", DateTime.Now.AddMinutes(-2));

            //Action
            var result = post.Validate();

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Domain_Invalid_NullOrEmpty_Message_Post_Test()
        {
            //Arrange
            var post = new Post();

            //Action
            var result = post.Validate();

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Domain_Invalid_Length_Message_Post_Test()
        {
            //Arrange
            var post = new Post();
            post.SetMessage(
                "asheiuasheiuasheiuasheiuaheiuahiuehiuAHeiuahieuhasiuehaiusehaiusheiuasheiuahsasheiuasheiuasheiuasheiuaheiuahiuehiuAHeiuahieuhasiuehaiusehaiusheiuasheiuahs",
                DateTime.Now.AddMinutes(-2));

            //Action
            var result = post.Validate();

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Domain_Invalid_Date_Post_Test()
        {
            //Arrange
            var post = new Post();
            post.SetMessage("Testando", DateTime.Now.AddMinutes(5));

            //Action
            var result = post.Validate();

            //Assert
            Assert.IsFalse(result);
        }
    }
}