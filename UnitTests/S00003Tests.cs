using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00003Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00003();
        sut.LengthOfLongestSubstring("abcabcbb").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00003();
        sut.LengthOfLongestSubstring("bbbbb").Should().Be(1);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00003();
        sut.LengthOfLongestSubstring("pwwkew").Should().Be(3);
    }
}