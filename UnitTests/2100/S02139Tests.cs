using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02139Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02139();
        Assert.That(sut.MinMoves(5, 0), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02139();
        Assert.That(sut.MinMoves(19, 2), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S02139();
        Assert.That(sut.MinMoves(10, 4), Is.EqualTo(4));
    }
}
