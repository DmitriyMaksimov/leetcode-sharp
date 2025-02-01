using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02490Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02490();
        Assert.That(sut.IsCircularSentence("leetcode exercises sound delightful"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02490();
        Assert.That(sut.IsCircularSentence("eetcode"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S02490();
        Assert.That(sut.IsCircularSentence("Leetcode is cool"), Is.False);
    }
}
