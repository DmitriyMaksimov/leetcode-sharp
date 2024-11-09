using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03330Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03330();
        sut.PossibleStringCount("abbcccc").Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S03330();
        sut.PossibleStringCount("abcd").Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S03330();
        sut.PossibleStringCount("aaaa").Should().Be(4);
    }
}