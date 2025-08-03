using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01425Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01425();
        Assert.That(sut.ConstrainedSubsetSum([10, 2, -10, 5, 20], 2), Is.EqualTo(37));
    }

    [Test]
    public void T2()
    {
        var sut = new S01425();
        Assert.That(sut.ConstrainedSubsetSum([-1, -2, -3], 1), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01425();
        Assert.That(sut.ConstrainedSubsetSum([10, -2, -10, -5, 20], 2), Is.EqualTo(23));
    }
}