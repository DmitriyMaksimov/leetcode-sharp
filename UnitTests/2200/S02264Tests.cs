using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02264Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02264();
        Assert.That(sut.LargestGoodInteger("6777133339"), Is.EqualTo("777"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02264();
        Assert.That(sut.LargestGoodInteger("2300019"), Is.EqualTo("000"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02264();
        Assert.That(sut.LargestGoodInteger("42352338"), Is.EqualTo(""));
    }
}