using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01218Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01218();
        Assert.That(sut.LongestSubsequence(new[] {1, 2, 3, 4}, 1), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01218();
        Assert.That(sut.LongestSubsequence(new[] {1, 3, 5, 7}, 1), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01218();
        Assert.That(sut.LongestSubsequence(new[] {1, 5, 7, 8, 5, 3, 4, 2, 1}, -2), Is.EqualTo(4));
    }
}