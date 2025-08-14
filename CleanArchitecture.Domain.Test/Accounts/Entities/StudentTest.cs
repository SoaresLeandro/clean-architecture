using CleanArchitecture.Domain.Accounts.Entities;

namespace CleanArchitecture.Domain.Test.Accounts.Entities;

public class StudentTest
{
    [Fact]
    public void Test1()
    {
        var student = new Student("Leandro", "Soares", "email@dominio.com", "12345678");
    }
}
