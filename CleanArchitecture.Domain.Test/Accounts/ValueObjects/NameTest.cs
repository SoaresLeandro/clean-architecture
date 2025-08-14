using CleanArchitecture.Domain.Accounts.ValueObjects;

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
            string data = _name;

            Assert.Equal("FirstName LastName", data);
        }
    }
}
