using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00874Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00874();
        sut.RobotSim([4, -1, 3], []).Should().Be(25);
    }

    [Test]
    public void T2()
    {
        var sut = new S00874();
        sut.RobotSim([4, -1, 4, -2, 4], [[2, 4]]).Should().Be(65);
    }

    [Test]
    public void T3()
    {
        var sut = new S00874();
        sut.RobotSim([6, -1, -1, 6], []).Should().Be(36);
    }
}
