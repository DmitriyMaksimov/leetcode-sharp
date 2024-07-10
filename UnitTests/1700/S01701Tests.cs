using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01701Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01701();
        sut.AverageWaitingTime([[1, 2], [2, 5], [4, 3]]).Should().BeApproximately(5, 1e-5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01701();
        sut.AverageWaitingTime([[5, 2], [5, 4], [10, 3], [20, 1]]).Should().BeApproximately(3.25, 1e-5);
    }
}