using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00003Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00003();
        Assert.That(sut.LengthOfLongestSubstring("abcabcbb"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00003();
        Assert.That(sut.LengthOfLongestSubstring("bbbbb"), Is.EqualTo(1));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00003();
        Assert.That(sut.LengthOfLongestSubstring("pwwkew"), Is.EqualTo(3));
    }
}