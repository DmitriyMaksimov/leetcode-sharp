using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01491Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01491();
        sut.Average(new[] {4000, 3000, 1000, 2000}).Should().Be(2500);
    }

    [Test]
    public void T2()
    {
        var sut = new S01491();
        sut.Average(new[] {1000, 2000, 3000}).Should().Be(2000);
    }

    [Test]
    public void T3()
    {
        var sut = new S01491();
        sut.Average(new[] {1000, 2000, 2001, 3000}).Should().Be(2000.5);
    }
}