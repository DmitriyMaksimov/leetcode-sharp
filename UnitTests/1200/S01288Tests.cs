using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01288Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01288();
        Assert.That(sut.RemoveCoveredIntervals([[1, 4], [3, 6], [2, 8]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01288();
        Assert.That(sut.RemoveCoveredIntervals([[1, 4], [2, 3]]), Is.EqualTo(1));
    }
}
