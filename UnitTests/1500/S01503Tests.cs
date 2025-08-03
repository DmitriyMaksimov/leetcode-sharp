using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01503Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01503();
        Assert.That(sut.GetLastMoment(4, [4, 3], [0, 1]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01503();
        Assert.That(sut.GetLastMoment(7, [], [0, 1, 2, 3, 4, 5, 6, 7]), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S01503();
        Assert.That(sut.GetLastMoment(7, [0, 1, 2, 3, 4, 5, 6, 7], []), Is.EqualTo(7));
    }
}