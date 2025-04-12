using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03272Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03272();
        Assert.That(sut.CountGoodIntegers(3, 5), Is.EqualTo(27));
    }

    [Test]
    public void T2()
    {
        var sut = new S03272();
        Assert.That(sut.CountGoodIntegers(1, 4), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03272();
        Assert.That(sut.CountGoodIntegers(5, 6), Is.EqualTo(2468));
    }
}
