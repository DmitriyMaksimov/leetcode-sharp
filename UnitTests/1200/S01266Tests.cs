using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01266Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01266();
        Assert.That(sut.MinTimeToVisitAllPoints([[1, 1], [3, 4], [-1, 0]]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S01266();
        Assert.That(sut.MinTimeToVisitAllPoints([[3, 2], [-2, 2]]), Is.EqualTo(5));
    }
}