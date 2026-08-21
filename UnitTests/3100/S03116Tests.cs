using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03116))]
public class S03116Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03116();
        Assert.That(sut.FindKthSmallest([3, 6, 9], 3), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S03116();
        Assert.That(sut.FindKthSmallest([5, 2], 7), Is.EqualTo(12));
    }

    [Test]
    public void T3()
    {
        var sut = new S03116();
        Assert.That(sut.FindKthSmallest([6, 5], 1435065516), Is.EqualTo(4305196548));
    }
}