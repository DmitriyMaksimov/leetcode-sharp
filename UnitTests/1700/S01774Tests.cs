using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01774))]
public class S01774Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01774();
        Assert.That(sut.ClosestCost([1, 7], [3, 4], 10), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S01774();
        Assert.That(sut.ClosestCost([2, 3], [4, 5, 100], 18), Is.EqualTo(17));
    }

    [Test]
    public void T3()
    {
        var sut = new S01774();
        Assert.That(sut.ClosestCost([3, 10], [2, 5], 9), Is.EqualTo(8));
    }
}