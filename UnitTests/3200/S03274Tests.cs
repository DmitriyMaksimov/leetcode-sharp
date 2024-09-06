using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03274Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03274();
        sut.CheckTwoChessboards("a1", "c3").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03274();
        sut.CheckTwoChessboards("a1", "h3").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S03274();
        sut.CheckTwoChessboards("a7", "a6").Should().BeFalse();
    }
}
