using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02523Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02523();
        Assert.That(sut.ClosestPrimes(10, 19), Is.EqualTo([11, 13]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02523();
        Assert.That(sut.ClosestPrimes(4, 6), Is.EqualTo([-1, -1]));
    }
}
