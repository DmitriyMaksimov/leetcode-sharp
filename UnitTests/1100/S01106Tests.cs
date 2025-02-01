using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01106Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01106();
        Assert.That(sut.ParseBoolExpr("&(|(f))"), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S01106();
        Assert.That(sut.ParseBoolExpr("|(f,f,f,t)"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S01106();
        Assert.That(sut.ParseBoolExpr("!(&(f,t))"), Is.True);
    }
}
