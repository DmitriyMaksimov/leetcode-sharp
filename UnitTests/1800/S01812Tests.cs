using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01812Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01812();
        Assert.That(sut.SquareIsWhite("a1"), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S01812();
        Assert.That(sut.SquareIsWhite("h3"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S01812();
        Assert.That(sut.SquareIsWhite("c7"), Is.False);
    }
}
