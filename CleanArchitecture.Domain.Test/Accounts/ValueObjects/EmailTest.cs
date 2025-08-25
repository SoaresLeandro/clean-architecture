using CleanArchitecture.Domain.Accounts.ValueObjects;
using CleanArchitecture.Domain.Accounts.ValueObjects.Exceptions;

namespace CleanArchitecture.Domain.Test.Accounts.ValueObjects
{
    public class EmailTest
    {
        [Theory]
        [InlineData("email@teste.com")]
        [InlineData("email@teste.com.br")]
        [InlineData("email@teste.br")]
        public void ShouldReturnSuccessWhenCreateAnEmail(string address)
        {
            var email = Email.Create(address);

            Assert.Equal(email.ToString(), address);
        }

        [Theory]
        [InlineData("email")]
        [InlineData("email.com")]
        public void ShouldReturnErrorWhenEmailIsInvalid(string address)
        {
            Assert.Throws<InvalidEmailException>(() =>
            {
                var email = Email.Create(address);
            });
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        public void ShouldReturnErrorWhenEmailLenghtIsInvalid(string address)
        {
            Assert.Throws<InvalidEmailLengthException>(() =>
            {
                var email = Email.Create("");
            });
        }
    }
}
