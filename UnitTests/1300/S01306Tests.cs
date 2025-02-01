using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01306Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01306();
        Assert.That(sut.CanReach([4, 2, 3, 0, 3, 1, 2], 5), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01306();
        Assert.That(sut.CanReach([4, 2, 3, 0, 3, 1, 2], 0), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S01306();
        Assert.That(sut.CanReach([3, 0, 2, 1, 2], 2), Is.False);
    }
}
