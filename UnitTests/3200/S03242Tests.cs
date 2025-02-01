using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03242Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03242.NeighborSum([[0, 1, 2], [3, 4, 5], [6, 7, 8]]);
        Assert.That(sut.AdjacentSum(1), Is.EqualTo(6));
        Assert.That(sut.AdjacentSum(4), Is.EqualTo(16));
        Assert.That(sut.DiagonalSum(4), Is.EqualTo(16));
        Assert.That(sut.DiagonalSum(8), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03242.NeighborSum([[1, 2, 0, 3], [4, 7, 15, 6], [8, 9, 10, 11], [12, 13, 14, 5]]);
        Assert.That(sut.AdjacentSum(15), Is.EqualTo(23));
        Assert.That(sut.DiagonalSum(9), Is.EqualTo(45));
    }
}
