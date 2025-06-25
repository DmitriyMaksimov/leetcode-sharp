using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02040))]
public class S02040Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02040();
        Assert.That(sut.KthSmallestProduct([2, 5], [3, 4], 2), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02040();
        Assert.That(sut.KthSmallestProduct([-4, -2, 0, 3], [2, 4], 6), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02040();
        Assert.That(sut.KthSmallestProduct([-2, -1, 0, 1, 2], [-3, -1, 2, 4, 5], 3), Is.EqualTo(-6));
    }
}