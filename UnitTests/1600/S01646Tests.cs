using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01646Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01646();
        Assert.That(sut.GetMaximumGenerated(7), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01646();
        Assert.That(sut.GetMaximumGenerated(2), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01646();
        Assert.That(sut.GetMaximumGenerated(3), Is.EqualTo(2));
    }
}