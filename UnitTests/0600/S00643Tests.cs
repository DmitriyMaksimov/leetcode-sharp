using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00643Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00643();
        Assert.That(sut.FindMaxAverage(new[] {1, 12, -5, -6, 50, 3}, 4), Is.EqualTo(12.75));
    }

    [Test]
    public void T2()
    {
        var sut = new S00643();
        Assert.That(sut.FindMaxAverage(new[] {5}, 1), Is.EqualTo(5));
    }
}