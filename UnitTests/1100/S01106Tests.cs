using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01106Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01106();
        sut.ParseBoolExpr("&(|(f))").Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S01106();
        sut.ParseBoolExpr("|(f,f,f,t)").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S01106();
        sut.ParseBoolExpr("!(&(f,t))").Should().BeTrue();
    }
}
