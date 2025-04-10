using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02999Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02999();
        Assert.That(sut.NumberOfPowerfulInt(1, 6000, 4, "124"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02999();
        Assert.That(sut.NumberOfPowerfulInt(15, 215, 6, "10"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02999();
        Assert.That(sut.NumberOfPowerfulInt(1000, 2000, 4, "3000"), Is.EqualTo(0));
    }
}
