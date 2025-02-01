using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02521Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02521();
        Assert.That(sut.DistinctPrimeFactors([2, 4, 3, 7, 10, 6]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02521();
        Assert.That(sut.DistinctPrimeFactors([2, 4, 8, 16]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02521();
        Assert.That(sut.DistinctPrimeFactors([27]), Is.EqualTo(1));
    }
}
