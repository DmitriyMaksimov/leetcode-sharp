using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03600))]
public class S03600Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03600();
        Assert.That(sut.MaxStability(3, [[0, 1, 2, 1], [1, 2, 3, 0]], 1), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03600();
        Assert.That(sut.MaxStability(3, [[0, 1, 4, 0], [1, 2, 3, 0], [0, 2, 1, 0]], 2), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S03600();
        Assert.That(sut.MaxStability(3, [[0, 1, 1, 1], [1, 2, 1, 1], [2, 0, 1, 1]], 0), Is.EqualTo(-1));
    }
}