using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01638Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01638();
        Assert.That(sut.CountSubstrings("aba", "baba"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S01638();
        Assert.That(sut.CountSubstrings("ab", "bb"), Is.EqualTo(3));
    }
}