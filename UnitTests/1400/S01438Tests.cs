using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01438Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01438();
        Assert.That(sut.LongestSubarray([8, 2, 4, 7], 4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01438();
        Assert.That(sut.LongestSubarray([10, 1, 2, 4, 7, 2], 5), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S01438();
        Assert.That(sut.LongestSubarray([4, 2, 2, 2, 4, 4, 2, 2], 0), Is.EqualTo(3));
    }
}