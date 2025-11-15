using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03712))]
public class S03712Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03712();
        Assert.That(sut.SumDivisibleByK([1, 2, 2, 3, 3, 3, 3, 4], 2), Is.EqualTo(16));
    }

    [Test]
    public void T2()
    {
        var sut = new S03712();
        Assert.That(sut.SumDivisibleByK([1, 2, 3, 4, 5], 2), Is.Zero);
    }

    [Test]
    public void T3()
    {
        var sut = new S03712();
        Assert.That(sut.SumDivisibleByK([4, 4, 4, 1, 2, 3], 3), Is.EqualTo(12));
    }
}