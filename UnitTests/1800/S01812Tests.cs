using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01812Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01812();
        sut.SquareIsWhite("a1").Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S01812();
        sut.SquareIsWhite("h3").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S01812();
        sut.SquareIsWhite("c7").Should().BeFalse();
    }
}