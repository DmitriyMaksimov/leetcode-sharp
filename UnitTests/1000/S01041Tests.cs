using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01041Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01041();
        Assert.That(sut.IsRobotBounded("GGLLGG"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01041();
        Assert.That(sut.IsRobotBounded("GG"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01041();
        Assert.That(sut.IsRobotBounded("GL"), Is.True);
    }
}
