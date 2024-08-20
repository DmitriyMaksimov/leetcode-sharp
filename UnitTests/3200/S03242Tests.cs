using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03242Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03242.NeighborSum([[0, 1, 2], [3, 4, 5], [6, 7, 8]]);
        sut.AdjacentSum(1).Should().Be(6);
        sut.AdjacentSum(4).Should().Be(16);
        sut.DiagonalSum(4).Should().Be(16);
        sut.DiagonalSum(8).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S03242.NeighborSum([[1, 2, 0, 3], [4, 7, 15, 6], [8, 9, 10, 11], [12, 13, 14, 5]]);
        sut.AdjacentSum(15).Should().Be(23);
        sut.DiagonalSum(9).Should().Be(45);
    }
}
