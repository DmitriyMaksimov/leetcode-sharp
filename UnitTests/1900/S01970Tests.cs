using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01970Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01970();
        Assert.That(sut.LatestDayToCross(2, 2, [[1, 1], [2, 1], [1, 2], [2, 2]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01970();
        Assert.That(sut.LatestDayToCross(2, 2, [[1, 1], [1, 2], [2, 1], [2, 2]]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01970();
        Assert.That(sut.LatestDayToCross(3, 3, [
            [1, 2], [2, 1], [3, 3], [2, 2], [1, 1], [1, 3], [2, 3], [3, 2], [3, 1]
        ]), Is.EqualTo(3));
    }
}