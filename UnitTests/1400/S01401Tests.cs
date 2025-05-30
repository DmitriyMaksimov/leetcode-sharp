using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01401))]
public class S01401Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01401();
        Assert.That(sut.CheckOverlap(1, 0, 0, 1, -1, 3, 1), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01401();
        Assert.That(sut.CheckOverlap(1, 1, 1, 1, -3, 2, -1), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01401();
        Assert.That(sut.CheckOverlap(1, 0, 0, -1, 0, 0, 1), Is.True);
    }
}
