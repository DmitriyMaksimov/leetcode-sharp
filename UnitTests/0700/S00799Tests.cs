using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00799Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00799();
        Assert.That(sut.ChampagneTower(1, 1, 1), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S00799();
        Assert.That(sut.ChampagneTower(2, 1, 1), Is.EqualTo(0.5));
    }

    [Test]
    public void T3()
    {
        var sut = new S00799();
        Assert.That(sut.ChampagneTower(100000009, 33, 17), Is.EqualTo(1));
    }
}