using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03381))]
public class S03381Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03381();
        Assert.That(sut.MaxSubarraySum([1, 2], 1), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03381();
        Assert.That(sut.MaxSubarraySum([-1, -2, -3, -4, -5], 4), Is.EqualTo(-10));
    }

    [Test]
    public void T3()
    {
        var sut = new S03381();
        Assert.That(sut.MaxSubarraySum([-5, 1, 2, -3, 4], 2), Is.EqualTo(4));
    }
}