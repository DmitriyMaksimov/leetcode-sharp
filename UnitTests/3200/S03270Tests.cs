using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03270Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03270();
        Assert.That(sut.GenerateKey(1, 10, 1000), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S03270();
        Assert.That(sut.GenerateKey(987, 879, 798), Is.EqualTo(777));
    }

    [Test]
    public void T3()
    {
        var sut = new S03270();
        Assert.That(sut.GenerateKey(1, 2, 3), Is.EqualTo(1));
    }
}
