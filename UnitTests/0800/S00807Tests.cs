using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00807Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00807();
        Assert.That(sut.MaxIncreaseKeepingSkyline([
            [3, 0, 8, 4], [2, 4, 5, 7], [9, 2, 6, 3], [0, 3, 1, 0]
        ]), Is.EqualTo(35));
    }

    [Test]
    public void T2()
    {
        var sut = new S00807();
        Assert.That(sut.MaxIncreaseKeepingSkyline([[0, 0, 0], [0, 0, 0], [0, 0, 0]]), Is.EqualTo(0));
    }
}