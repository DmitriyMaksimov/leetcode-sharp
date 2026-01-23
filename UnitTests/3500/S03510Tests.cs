using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03510))]
public class S03510Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03510();
        Assert.That(sut.MinimumPairRemoval([5, 2, 3, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03510();
        Assert.That(sut.MinimumPairRemoval([1, 2, 2]), Is.Zero);
    }

    [Test]
    public void T3()
    {
        var sut = new S03510();
        Assert.That(sut.MinimumPairRemoval([2, 2, -1, 3, -2, 2, 1, 1, 1, 0, -1]), Is.EqualTo(9));
    }

    [Test]
    public void T4()
    {
        var sut = new S03510();
        Assert.That(sut.MinimumPairRemoval([3, 6, 4, -6, 2, -4, 5, -7, -3, 6, 3, -4]), Is.EqualTo(10));
    }
}