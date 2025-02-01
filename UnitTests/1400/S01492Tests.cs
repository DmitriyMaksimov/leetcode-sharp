using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01492Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01492();
        Assert.That(sut.KthFactor(12, 3), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01492();
        Assert.That(sut.KthFactor(7, 2), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S01492();
        Assert.That(sut.KthFactor(4, 4), Is.EqualTo(-1));
    }
}
