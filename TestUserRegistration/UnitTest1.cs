using NUnit.Framework;
using System;
using UserRegistration;

namespace TestUserRegistration
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {   
        }

        UserValidation userValidation = new UserValidation();

        [Test]
        public void Test1()
        {
            Boolean result = userValidation.FirstName("Datta");
            Assert.True(result);
        } 
    }
}