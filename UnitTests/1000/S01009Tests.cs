using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01009Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01009();
        Assert.That(sut.BitwiseComplement(5), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01009();
        Assert.That(sut.BitwiseComplement(7), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01009();
        Assert.That(sut.BitwiseComplement(10), Is.EqualTo(5));
    }
}