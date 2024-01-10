using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02996Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02996();
        sut.MissingInteger(new[] {1, 2, 3, 2, 5}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02996();
        sut.MissingInteger(new[] {3, 4, 5, 1, 12, 14, 13}).Should().Be(15);
    }
}