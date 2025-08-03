using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00209Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00209();
        Assert.That(sut.MinSubArrayLen(7, [2, 3, 1, 2, 4, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00209();
        Assert.That(sut.MinSubArrayLen(4, [1, 4, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00209();
        Assert.That(sut.MinSubArrayLen(11, [1, 1, 1, 1, 1, 1, 1, 1]), Is.EqualTo(0));
    }
}