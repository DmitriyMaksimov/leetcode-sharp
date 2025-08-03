using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02352Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02352();
        Assert.That(sut.EqualPairs([[3, 2, 1], [1, 7, 6], [2, 7, 7]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02352();
        Assert.That(sut.EqualPairs([[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02352();
        Assert.That(sut.EqualPairs([
            [3, 1, 2, 2],
            [1, 4, 4, 4],
            [2, 4, 2, 2],
            [2, 5, 2, 2]
        ]), Is.EqualTo(3));
    }
}