using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01074Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01074();
        sut.NumSubmatrixSumTarget([[0, 1, 0], [1, 1, 1], [0, 1, 0]], 0).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01074();
        sut.NumSubmatrixSumTarget([[1, -1], [-1, 1]], 0).Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01074();
        sut.NumSubmatrixSumTarget([[904]], 0).Should().Be(0);
    }
}