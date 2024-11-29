using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01041Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01041();
        sut.IsRobotBounded("GGLLGG").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01041();
        sut.IsRobotBounded("GG").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01041();
        sut.IsRobotBounded("GL").Should().BeTrue();
    }
}
