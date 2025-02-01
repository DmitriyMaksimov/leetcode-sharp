using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00290Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00290();
        Assert.That(sut.WordPattern("abba", "dog cat cat dog"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00290();
        Assert.That(sut.WordPattern("abba", "dog cat cat fish"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00290();
        Assert.That(sut.WordPattern("aaaa", "dog cat cat dog"), Is.False);
    }

    [Test]
    public void T4()
    {
        var sut = new S00290();
        Assert.That(sut.WordPattern("abba", "dog dog dog dog"), Is.False);
    }

    [Test]
    public void T5()
    {
        var sut = new S00290();
        Assert.That(sut.WordPattern("aaa", "aa aa aa aa"), Is.False);
    }
}
