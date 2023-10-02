using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02038Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02038();
        sut.WinnerOfGame("AAABABB").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02038();
        sut.WinnerOfGame("AA").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S02038();
        sut.WinnerOfGame("ABBBBBBBAAA").Should().BeFalse();
    }

    [Test]
    public void T4()
    {
        var sut = new S02038();
        sut.WinnerOfGame("AAAAABBB").Should().BeTrue();
    }
}