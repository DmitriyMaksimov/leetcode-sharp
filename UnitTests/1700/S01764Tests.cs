using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01764Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01764();
        Assert.That(sut.CanChoose([[1, -1, -1], [3, -2, 0]], [1, -1, 0, 1, -1, -1, 3, -2, 0]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01764();
        Assert.That(sut.CanChoose([[10, -2], [1, 2, 3, 4]], [1, 2, 3, 4, 10, -2]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01764();
        Assert.That(sut.CanChoose([[1, 2, 3], [3, 4]], [7, 7, 1, 2, 3, 4, 7, 7]), Is.False);
    }
}
