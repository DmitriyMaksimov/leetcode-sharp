using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01665))]
public class S01665Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01665();
        Assert.That(sut.MinimumEffort([[1, 2], [2, 4], [4, 8]]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S01665();
        Assert.That(sut.MinimumEffort([[1, 3], [2, 4], [10, 11], [10, 12], [8, 9]]), Is.EqualTo(32));
    }

    [Test]
    public void T3()
    {
        var sut = new S01665();
        Assert.That(sut.MinimumEffort([[1, 7], [2, 8], [3, 9], [4, 10], [5, 11], [6, 12]]), Is.EqualTo(27));
    }
}