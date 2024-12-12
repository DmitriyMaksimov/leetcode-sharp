using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00813Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00813();
        sut.LargestSumOfAverages([9, 1, 2, 3, 9], 3).Should().BeApproximately(20, 0.000001);
    }

    [Test]
    public void T2()
    {
        var sut = new S00813();
        sut.LargestSumOfAverages([1, 2, 3, 4, 5, 6, 7], 4).Should().BeApproximately(20.5, 0.000001);
    }
}
