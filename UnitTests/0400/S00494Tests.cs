using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00494Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00494();
        sut.FindTargetSumWays([1, 1, 1, 1, 1], 3).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S00494();
        sut.FindTargetSumWays([1], 1).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00494();
        sut.FindTargetSumWays([100], -200).Should().Be(0);
    }
}
