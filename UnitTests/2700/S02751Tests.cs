using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02751Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02751();
        sut.SurvivedRobotsHealths([5, 4, 3, 2, 1], [2, 17, 9, 15, 10], "RRRRR").Should().Equal(2, 17, 9, 15, 10);
    }

    [Test]
    public void T2()
    {
        var sut = new S02751();
        sut.SurvivedRobotsHealths([3, 5, 2, 6], [10, 10, 15, 12], "RLRL").Should().Equal(14);
    }

    [Test]
    public void T3()
    {
        var sut = new S02751();
        sut.SurvivedRobotsHealths([1, 2, 5, 6], [10, 10, 11, 11], "RLRL").Should().BeEmpty();
    }
}