using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02981Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02981();
        Assert.That(sut.MaximumLength("aaaa"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02981();
        Assert.That(sut.MaximumLength("abcdef"), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02981();
        Assert.That(sut.MaximumLength("abcaba"), Is.EqualTo(1));
    }
}
