using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01347Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01347();
        Assert.That(sut.MinSteps("bab", "aba"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01347();
        Assert.That(sut.MinSteps("leetcode", "practice"), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01347();
        Assert.That(sut.MinSteps("anagram", "mangaar"), Is.EqualTo(0));
    }
}