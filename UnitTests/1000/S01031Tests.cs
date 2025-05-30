using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01031Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01031();
        Assert.That(sut.MaxSumTwoNoOverlap([0, 6, 5, 2, 2, 5, 1, 9, 4], 1, 2), Is.EqualTo(20));
    }

    [Test]
    public void T2()
    {
        var sut = new S01031();
        Assert.That(sut.MaxSumTwoNoOverlap([3, 8, 1, 3, 2, 1, 8, 9, 0], 3, 2), Is.EqualTo(29));
    }

    [Test]
    public void T3()
    {
        var sut = new S01031();
        Assert.That(sut.MaxSumTwoNoOverlap([2, 1, 5, 6, 0, 9, 5, 0, 3, 8], 4, 3), Is.EqualTo(31));
    }
}
