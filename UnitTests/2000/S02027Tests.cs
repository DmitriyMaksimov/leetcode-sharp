using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02027Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02027();
        Assert.That(sut.MinimumMoves("XXX"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02027();
        Assert.That(sut.MinimumMoves("XXOX"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02027();
        Assert.That(sut.MinimumMoves("OOOO"), Is.EqualTo(0));
    }
}