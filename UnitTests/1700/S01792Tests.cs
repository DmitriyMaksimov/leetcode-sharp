using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01792Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01792();
        sut.MaxAverageRatio([[1, 2], [3, 5], [2, 2]], 2).Should().BeApproximately(0.78333, 0.00001);
    }

    [Test]
    public void T2()
    {
        var sut = new S01792();
        sut.MaxAverageRatio([[2, 4], [3, 9], [4, 5], [2, 10]], 4).Should().BeApproximately(0.53485, 0.00001);
    }
}
