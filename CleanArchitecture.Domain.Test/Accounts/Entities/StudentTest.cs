using CleanArchitecture.Domain.Accounts.Entities;
using CleanArchitecture.Domain.Shared.Abstractions;
using CleanArchitecture.Domain.Test.Mocks;

namespace CleanArchitecture.Domain.Test.Accounts.Entities;

public class StudentTest
{
    private readonly IDateTimeProvider _dateTimeProvider = new FakeDateTimeProvider();
    [Fact]
    public void Test1()
    {
        var student = Student.Create("Leandro", "Soares", "email@dominio.com", _dateTimeProvider);
    }
}
