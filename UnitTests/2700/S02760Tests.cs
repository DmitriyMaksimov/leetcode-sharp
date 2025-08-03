using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02760Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02760();
        Assert.That(sut.LongestAlternatingSubarray([3, 2, 5, 4], 5), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02760();
        Assert.That(sut.LongestAlternatingSubarray([1, 2], 2), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02760();
        Assert.That(sut.LongestAlternatingSubarray([2, 3, 4, 5], 4), Is.EqualTo(3));
    }
}