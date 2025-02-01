using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02501Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02501();
        Assert.That(sut.LongestSquareStreak([4, 3, 6, 16, 8, 2]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02501();
        Assert.That(sut.LongestSquareStreak([2, 3, 5, 6, 7]), Is.EqualTo(-1));
    }
}
