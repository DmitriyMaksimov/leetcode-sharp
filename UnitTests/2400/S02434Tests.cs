using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02434))]
public class S02434Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02434();
        Assert.That(sut.RobotWithString("zza"), Is.EqualTo("azz"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02434();
        Assert.That(sut.RobotWithString("bac"), Is.EqualTo("abc"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02434();
        Assert.That(sut.RobotWithString("bdda"), Is.EqualTo("addb"));
    }
}
