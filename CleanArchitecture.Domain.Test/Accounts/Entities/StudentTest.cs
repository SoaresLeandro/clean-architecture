using CleanArchitecture.Domain.Accounts.Entities;
using CleanArchitecture.Domain.Shared.Abstractions;
using CleanArchitecture.Domain.Test.Mocks;

namespace CleanArchitecture.Domain.Test.Accounts.Entities;

public class StudentTest
{
    private readonly IDateTimeProvider _dateTimeProvider = new FakeDateTimeProvider();

    [Fact]
    public void ShouldRaiseOnStudentCreatedEvent()
    {
        var student = Student.Create("Leandro", "Soares", "email@dominio.com", _dateTimeProvider);

        Assert.Single(student.Events);
    }
}
