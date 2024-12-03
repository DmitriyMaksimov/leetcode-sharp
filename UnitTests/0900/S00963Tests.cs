using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00963Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00963();
        sut.MinAreaFreeRect([[1, 2], [2, 1], [1, 0], [0, 1]]).Should().BeApproximately(2, 0.001);
    }

    [Test]
    public void T2()
    {
        var sut = new S00963();
        sut.MinAreaFreeRect([[0, 1], [2, 1], [1, 1], [1, 0], [2, 0]]).Should().BeApproximately(1, 0.001);
    }

    [Test]
    public void T3()
    {
        var sut = new S00963();
        sut.MinAreaFreeRect([[0, 3], [1, 2], [3, 1], [1, 3], [2, 1]]).Should().BeApproximately(0, 0.001);
    }
}
