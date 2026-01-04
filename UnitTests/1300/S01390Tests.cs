using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01390))]
public class S01390Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01390();
        Assert.That(sut.SumFourDivisors([21, 4, 7]), Is.EqualTo(32));
    }

    [Test]
    public void T2()
    {
        var sut = new S01390();
        Assert.That(sut.SumFourDivisors([21, 21]), Is.EqualTo(64));
    }

    [Test]
    public void T3()
    {
        var sut = new S01390();
        Assert.That(sut.SumFourDivisors([1, 2, 3, 4, 5]), Is.Zero);
    }
}