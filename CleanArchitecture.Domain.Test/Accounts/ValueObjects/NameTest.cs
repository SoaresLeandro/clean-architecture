using CleanArchitecture.Domain.Accounts.ValueObjects;
using CleanArchitecture.Domain.Accounts.ValueObjects.Exceptions;
using System.Security.Cryptography;

namespace CleanArchitecture.Domain.Test.Accounts.ValueObjects
{
    public class NameTest
    {
        private readonly string _name = Name.Create("FirstName", "LastName");

        [Fact]
        public void ShouldOverrideToStringMethod()
        {
            Assert.Equal("FirstName LastName", _name.ToString());
        }

        [Fact]
        public void ShouldImplictConvertToStringMethod()
        {
            var name = _name;

            Assert.Equal("FirstName LastName", name);
        }

        [Fact]
        public void ShouldReturnSucessWhenCreatingAName()
        {
            var name = Name.Create("FirstName", "LastName");

            Assert.Equal("FirstName LastName", name);
        }

        [Fact]
        public void ShouldReturnErrorIfFirstNameIsNotValid()
        { 
            Assert.Throws<InvalidFirstNameLenghtException>(() =>
            {
                var name = Name.Create("F", "LastName");
            });
        }

        [Fact]
        public void ShouldReturnErrorIfLastNameIsNotValid()
        {
            Assert.Throws<InvalidLastNameLenghtException>(() =>
            {
                var name = Name.Create("FirstName", "L");
            });
        }

        [Fact]
        public void ShouldReturnErrorIfNameIsNotValid()
        {
            Assert.Throws<InvalidNameException>(() =>
            {
                var name = Name.Create("F", "L");
            });
        }
    }
}
