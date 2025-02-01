using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00991Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00991();
        Assert.That(sut.BrokenCalc(2, 3), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00991();
        Assert.That(sut.BrokenCalc(5, 8), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00991();
        Assert.That(sut.BrokenCalc(3, 10), Is.EqualTo(3));
    }
}
