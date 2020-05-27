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
        public void GivenProperFirstName_ShouldReturnTrue()
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
        public void GivenNumbersInFirstName_ShouldReturnFalse()
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

        [Test]
        public void GivenProperLastName_ShouldReturnTrue()
        {
            Boolean result = userValidation.LastName("Dhebe");
            Assert.True(result);
        }

        [Test]
        public void GivenLastNameLessThanThreeCharacter_ShouldReturnFalse()
        {
            Boolean result = userValidation.LastName("Dh");
            Assert.False(result);
        }

        [Test]
        public void GivenNumbersInLastName_ShouldReturnFalse()
        {
            Boolean result = userValidation.LastName("Dh34");
            Assert.False(result);
        }

        [Test]
        public void GivenEmptyLastName_ShouldReturnFalse()
        {
            Boolean result = userValidation.LastName("");
            Assert.False(result);
        }



    }
}