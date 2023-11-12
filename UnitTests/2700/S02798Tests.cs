using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02798Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02798();
        sut.NumberOfEmployeesWhoMetTarget(new[] {0, 1, 2, 3, 4}, 2).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02798();
        sut.NumberOfEmployeesWhoMetTarget(new[] {5, 1, 4, 2, 2}, 6).Should().Be(0);
    }
}