using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01970Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01970();
        Assert.That(sut.LatestDayToCross(2, 2, new[] {new[] {1, 1}, new[] {2, 1}, new[] {1, 2}, new[] {2, 2}}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01970();
        Assert.That(sut.LatestDayToCross(2, 2, new[] {new[] {1, 1}, new[] {1, 2}, new[] {2, 1}, new[] {2, 2}}), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01970();
        Assert.That(sut.LatestDayToCross(3, 3, new[] {new[] {1, 2}, new[] {2, 1}, new[] {3, 3}, new[] {2, 2}, new[] {1, 1}, new[] {1, 3}, new[] {2, 3}, new[] {3, 2}, new[] {3, 1}}), Is.EqualTo(3));
    }
}