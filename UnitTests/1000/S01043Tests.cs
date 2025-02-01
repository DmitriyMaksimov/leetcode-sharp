using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01043Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01043();
        Assert.That(sut.MaxSumAfterPartitioning([1, 15, 7, 9, 2, 5, 10], 3), Is.EqualTo(84));
    }

    [Test]
    public void T2()
    {
        var sut = new S01043();
        Assert.That(sut.MaxSumAfterPartitioning([1, 4, 1, 5, 7, 3, 6, 1, 9, 9, 3], 4), Is.EqualTo(83));
    }

    [Test]
    public void T3()
    {
        var sut = new S01043();
        Assert.That(sut.MaxSumAfterPartitioning([1], 1), Is.EqualTo(1));
    }
}