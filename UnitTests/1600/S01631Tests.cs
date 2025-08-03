using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01631Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01631();
        Assert.That(sut.MinimumEffortPath([[1, 2, 2], [3, 8, 2], [5, 3, 5]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01631();
        Assert.That(sut.MinimumEffortPath([[1, 2, 3], [3, 8, 4], [5, 3, 5]]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01631();
        Assert.That(sut.MinimumEffortPath([
            [1, 2, 1, 1, 1],
            [1, 2, 1, 2, 1],
            [1, 2, 1, 2, 1],
            [1, 2, 1, 2, 1],
            [1, 1, 1, 2, 1]
        ]), Is.EqualTo(0));
    }
}