using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01647Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01647();
        Assert.That(sut.MinDeletions("aab"), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S01647();
        Assert.That(sut.MinDeletions("aaabbbcc"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01647();
        Assert.That(sut.MinDeletions("ceabaacb"), Is.EqualTo(2));
    }
}