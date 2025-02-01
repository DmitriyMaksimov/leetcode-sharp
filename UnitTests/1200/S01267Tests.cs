using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01267Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01267();
        Assert.That(sut.CountServers([[1, 0], [0, 1]]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S01267();
        Assert.That(sut.CountServers([[1, 0], [1, 1]]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01267();
        Assert.That(sut.CountServers([[1, 1, 0, 0], [0, 0, 1, 0], [0, 0, 1, 0], [0, 0, 0, 1]]), Is.EqualTo(4));
    }
}
