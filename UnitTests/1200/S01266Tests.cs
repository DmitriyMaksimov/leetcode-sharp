using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01266Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01266();
        Assert.That(sut.MinTimeToVisitAllPoints(new[] {new[] {1, 1}, new[] {3, 4}, new[] {-1, 0}}), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S01266();
        Assert.That(sut.MinTimeToVisitAllPoints(new[] {new[] {3, 2}, new[] {-2, 2}}), Is.EqualTo(5));
    }
}