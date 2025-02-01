using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00868Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00868();
        Assert.That(sut.BinaryGap(22), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00868();
        Assert.That(sut.BinaryGap(8), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00868();
        Assert.That(sut.BinaryGap(5), Is.EqualTo(2));
    }
}