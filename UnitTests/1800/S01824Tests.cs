using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01824Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01824();
        Assert.That(sut.MinSideJumps([0, 1, 2, 3, 0]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01824();
        Assert.That(sut.MinSideJumps([0, 1, 1, 3, 3, 0]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01824();
        Assert.That(sut.MinSideJumps([0, 2, 1, 0, 3, 0]), Is.EqualTo(2));
    }
}
