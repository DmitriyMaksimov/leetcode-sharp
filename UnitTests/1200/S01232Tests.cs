using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01232Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01232();
        Assert.That(sut.CheckStraightLine([
            [1, 2], [2, 3], [3, 4], [4, 5], [5, 6], [6, 7]
        ]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01232();
        Assert.That(sut.CheckStraightLine([
            [1, 1], [2, 3], [3, 4], [4, 5], [5, 6], [7, 7]
        ]), Is.False);
    }
}
