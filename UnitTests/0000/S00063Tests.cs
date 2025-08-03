using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00063Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00063();
        Assert.That(sut.UniquePathsWithObstacles([[0, 0, 0], [0, 1, 0], [0, 0, 0]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00063();
        Assert.That(sut.UniquePathsWithObstacles([[0, 1], [0, 0]]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00063();
        Assert.That(sut.UniquePathsWithObstacles([[0, 0], [0, 1]]), Is.EqualTo(0));
    }

    [Test]
    public void T4()
    {
        var sut = new S00063();
        Assert.That(sut.UniquePathsWithObstacles([[0, 0], [1, 1], [0, 0]]), Is.EqualTo(0));
    }
}