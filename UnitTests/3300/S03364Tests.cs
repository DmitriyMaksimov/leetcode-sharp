using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03364Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03364();
        Assert.That(sut.MinimumSumSubarray([3, -2, 1, 4], 2, 3), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03364();
        Assert.That(sut.MinimumSumSubarray([-2, 2, -3, 1], 2, 3), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03364();
        Assert.That(sut.MinimumSumSubarray([1, 2, 3, 4], 2, 4), Is.EqualTo(3));
    }
}
