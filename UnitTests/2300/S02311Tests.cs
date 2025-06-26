using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02311))]
public class S02311Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02311();
        Assert.That(sut.LongestSubsequence("1001010", 5), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02311();
        Assert.That(sut.LongestSubsequence("00101001", 1), Is.EqualTo(6));
    }
}