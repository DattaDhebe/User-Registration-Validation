using NUnit.Framework;
using System;
using UserRegistration;

namespace TestUserRegistration
{
    public class Tests
    {
        [SetUp]
        public void Setup() {   }

        UserValidation userValidation = new UserValidation();

        [Test]
        public void GivenProperName_ShouldReturnTrue()
        {
            Boolean result = userValidation.FirstName("Datta");
            Assert.True(result);
        }

        [Test]
        public void GivenLessThanThreeCharacter_ShouldReturnFalse()
        {
            Boolean result = userValidation.FirstName("Da");
            Assert.False(result);
        }

        [Test]
        public void GivenNumbersInName_ShouldReturnFalse()
        {
            Boolean result = userValidation.FirstName("Da324");
            Assert.False(result);
        }

        [Test]
        public void GivenEmptyName_ShouldReturnFalse()
        {
            Boolean result = userValidation.FirstName("");
            Assert.False(result);
        }

    }
}