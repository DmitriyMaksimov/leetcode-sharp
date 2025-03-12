using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00672Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00672();
        Assert.That(sut.FlipLights(1, 1), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00672();
        Assert.That(sut.FlipLights(2, 1), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00672();
        Assert.That(sut.FlipLights(3, 1), Is.EqualTo(4));
    }
}
