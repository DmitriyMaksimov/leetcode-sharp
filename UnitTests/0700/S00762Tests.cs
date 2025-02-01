using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00762Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00762();
        Assert.That(sut.CountPrimeSetBits(6, 10), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00762();
        Assert.That(sut.CountPrimeSetBits(10, 15), Is.EqualTo(5));
    }
}