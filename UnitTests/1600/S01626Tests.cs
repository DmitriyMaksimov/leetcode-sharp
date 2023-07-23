using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01626Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01626();
        sut.BestTeamScore(new[] {1, 3, 5, 10, 15}, new[] {1, 2, 3, 4, 5}).Should().Be(34);
    }

    [Test]
    public void T2()
    {
        var sut = new S01626();
        sut.BestTeamScore(new[] {4, 5, 6, 5}, new[] {2, 1, 2, 1}).Should().Be(16);
    }

    [Test]
    public void T3()
    {
        var sut = new S01626();
        sut.BestTeamScore(new[] {1, 2, 3, 5}, new[] {8, 9, 10, 1}).Should().Be(6);
    }
}