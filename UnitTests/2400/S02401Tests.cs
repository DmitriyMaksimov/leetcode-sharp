using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02401Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02401();
        Assert.That(sut.LongestNiceSubarray([1, 3, 8, 48, 10]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02401();
        Assert.That(sut.LongestNiceSubarray([3, 1, 5, 11, 13]), Is.EqualTo(1));
    }
}
