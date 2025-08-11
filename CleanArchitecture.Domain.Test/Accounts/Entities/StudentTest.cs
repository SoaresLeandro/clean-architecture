using CleanArchitecture.Domain.Accounts.Entities;

namespace CleanArchitecture.Domain.Test.Accounts.Entities;

public class StudentTest
{
    [Fact]
    public void Test1()
    {
        var student = new Student();
        student.FirstName = "Test";
        student.LastName = "Test";
        student.Email = "Test";
        student.Password = "Test";
    }
}
