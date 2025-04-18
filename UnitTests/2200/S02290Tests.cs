using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02290Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02290();
        Assert.That(sut.MinimumObstacles([[0, 1, 1], [1, 1, 0], [1, 1, 0]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02290();
        Assert.That(sut.MinimumObstacles([[0, 1, 0, 0, 0], [0, 1, 0, 1, 0], [0, 0, 0, 1, 0]]), Is.EqualTo(0));
    }
}
