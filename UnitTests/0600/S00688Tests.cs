using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00688Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00688();
        sut.KnightProbability(3, 2, 0, 0).Should().BeApproximately(0.06250, 0.001);
    }

    [Test]
    public void T2()
    {
        var sut = new S00688();
        sut.KnightProbability(1, 0, 0, 0).Should().BeApproximately(1, 0.001);
    }
}