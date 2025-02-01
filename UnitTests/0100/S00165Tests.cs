using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00165Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00165();
        Assert.That(sut.CompareVersion("1.01", "1.001"), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S00165();
        Assert.That(sut.CompareVersion("1.0", "1.0.0"), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00165();
        Assert.That(sut.CompareVersion("0.1", "1.1"), Is.EqualTo(-1));
    }

    [Test]
    public void T4()
    {
        var sut = new S00165();
        Assert.That(sut.CompareVersion("1.0.1", "1.0"), Is.EqualTo(1));
    }
}