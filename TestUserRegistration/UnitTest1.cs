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

        [Test]
        public void GivenProperEmail_ShouldReturnTrue()
        {
            Boolean result = userValidation.Email("abc.xyz@bl.co.in");
            Assert.True(result);
        }

        [Test]
        public void GivenProperEmail_WhileRemovingOptionalPart_ShouldReturnTrue()
        {
            Boolean result = userValidation.Email("xyz@bl.co");
            Assert.True(result);
        }

        [Test]
        public void GivenWrongEmail_ShouldReturnFalse()
        {
            Boolean result = userValidation.Email("xyz@bl.co.in.fi");
            Assert.False(result);
        }

        [Test]
        public void GivenWrongEmail_ByRemoving_AtTheRateSign_ShouldReturnFalse()
        {
            Boolean result = userValidation.Email("xy.co.in.fi");
            Assert.False(result);
        }

        [Test]
        public void GivenWrongEmail_ByAddignDotBefore_AtTheRateSign_ShouldReturnFalse()
        {
            Boolean result = userValidation.Email("xy.@co.in");
            Assert.False(result);
        }

        [Test]
        public void GivenEmptyEmail_ShouldReturnFalse()
        {
            Boolean result = userValidation.Email("xy.@co.in");
            Assert.False(result);
        }

        [Test]
        public void GivenProperMobileNumber_ShouldReturnTrue()
        {
            Boolean result = userValidation.Mobile("87 0123456789");
            Assert.True(result);
        }

        [Test]
        public void GivenStringFormat_ShouldReturnFalse()
        {
            Boolean result = userValidation.Mobile("abcs");
            Assert.False(result);
        }

        [Test]
        public void GivenLessNumberOfDigit_ShouldReturnFalse()
        {
            Boolean result = userValidation.Mobile("5842");
            Assert.False(result);
        }

        [Test]
        public void GivenExactNumberOfDigit_ShouldReturnTrue()
        {
            Boolean result = userValidation.Mobile("8149277030");
            Assert.True(result);
        }

        [Test]
        public void GivenProperPassword_ShouldReturnTrue()
        {
            Boolean result = userValidation.Password("gatHSHD8623");
            Assert.True(result);
        }

        [Test]
        public void GivenLessCharacterInPassword_ShouldReturnFalse()
        {
            Boolean result = userValidation.Password("gatHS");
            Assert.False(result);
        }

        [Test]
        public void GivenExactEightCharacterInPassword_ShouldReturnTrue()
        {
            Boolean result = userValidation.Password("gaAshdeu");
            Assert.True(result);
        }

        [Test]
        public void GivenAtLeastOneCapitalLetter_AtTheBegining_ShouldReturnTrue()
        {
            Boolean result = userValidation.Password("Aatsashdekshdu");
            Assert.True(result);
        }

        [Test]
        public void GivenAtLeastOneCapitalLetter_AtTheMiddle_ShouldReturnTrue()
        {
            Boolean result = userValidation.Password("atsashdAshdu");
            Assert.True(result);
        }

        [Test]
        public void GivenAtLeastOneCapitalLetter_AtTheEnd_ShouldReturnTrue()
        {
            Boolean result = userValidation.Password("atsashdashdU");
            Assert.True(result);
        }

        [Test]
        public void GivenMoreThanOneCapitalLetter_ShouldReturnTrue()
        {
            Boolean result = userValidation.Password("DtsasAdashdU");
            Assert.True(result);
        }

    }
}