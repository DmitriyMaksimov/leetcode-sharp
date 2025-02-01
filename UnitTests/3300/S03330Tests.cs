using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03330Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03330();
        Assert.That(sut.PossibleStringCount("abbcccc"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03330();
        Assert.That(sut.PossibleStringCount("abcd"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03330();
        Assert.That(sut.PossibleStringCount("aaaa"), Is.EqualTo(4));
    }
}