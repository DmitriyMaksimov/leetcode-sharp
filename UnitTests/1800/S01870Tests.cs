using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01870Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01870();
        Assert.That(sut.MinSpeedOnTime([1, 3, 2], 6), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01870();
        Assert.That(sut.MinSpeedOnTime([1, 3, 2], 2.7), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01870();
        Assert.That(sut.MinSpeedOnTime([1, 3, 2], 1.9), Is.EqualTo(-1));
    }
}