using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00438Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00438();
        Assert.That(sut.FindAnagrams("cbaebabacd", "abc"), Is.EquivalentTo(new[] {0, 6}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00438();
        Assert.That(sut.FindAnagrams("abab", "ab"), Is.EquivalentTo(new[] {0, 1, 2}));
    }

    [Test]
    public void T3()
    {
        var sut = new S00438();
        sut.FindAnagrams("aaaaaaaaaa", "aaaaaaaaaaaaa").Should().BeEmpty();
    }
}