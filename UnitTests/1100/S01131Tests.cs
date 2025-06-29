using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01131))]
public class S01131Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01131();
        Assert.That(sut.MaxAbsValExpr([1, 2, 3, 4], [-1, 4, 5, 6]), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S01131();
        Assert.That(sut.MaxAbsValExpr([1, -2, -5, 0, 10], [0, -2, -1, -7, -4]), Is.EqualTo(20));
    }
}