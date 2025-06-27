using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02014))]
public class S02014Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02014();
        Assert.That(sut.LongestSubsequenceRepeatedK("letsleetcode", 2), Is.EqualTo("let"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02014();
        Assert.That(sut.LongestSubsequenceRepeatedK("bb", 2), Is.EqualTo("b"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02014();
        Assert.That(sut.LongestSubsequenceRepeatedK("ab", 2), Is.EqualTo(""));
    }

    [Test]
    public void T4()
    {
        var sut = new S02014();
        Assert.That(sut.LongestSubsequenceRepeatedK("xwwyzxyzww", 2), Is.EqualTo("xyz"));
    }
}