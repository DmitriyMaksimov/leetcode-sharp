using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01319Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01319();
        Assert.That(sut.MakeConnected(4, [[0, 1], [0, 2], [1, 2]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01319();
        Assert.That(sut.MakeConnected(6, [[0, 1], [0, 2], [0, 3], [1, 2]]), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01319();
        Assert.That(sut.MakeConnected(6, [[0, 1], [0, 2], [0, 3], [1, 2], [1, 3]]), Is.EqualTo(2));
    }
}