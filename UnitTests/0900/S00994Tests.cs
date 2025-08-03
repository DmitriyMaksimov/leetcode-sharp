using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00994Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00994();
        Assert.That(sut.OrangesRotting([[2, 1, 1], [1, 1, 0], [0, 1, 1]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00994();
        Assert.That(sut.OrangesRotting([[2, 1, 1], [0, 1, 1], [1, 0, 1]]), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00994();
        Assert.That(sut.OrangesRotting([[0, 2]]), Is.EqualTo(0));
    }
}