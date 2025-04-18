using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00885Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00885();
        var matrix = sut.SpiralMatrixIII(1, 4, 0, 0);
        Assert.That(matrix, Is.EquivalentTo((int[][]) [[0, 0], [0, 1], [0, 2], [0, 3]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00885();
        var matrix = sut.SpiralMatrixIII(5, 6, 1, 4);
        Assert.That(matrix, Is.EquivalentTo(
            (int[][]) [[1, 4], [1, 5], [2, 5], [2, 4], [2, 3], [1, 3], [0, 3], [0, 4], [0, 5], [3, 5], [3, 4], [3, 3],
            [3, 2], [2, 2], [1, 2], [0, 2], [4, 5], [4, 4], [4, 3], [4, 2], [4, 1], [3, 1], [2, 1], [1, 1], [0, 1],
            [4, 0], [3, 0], [2, 0], [1, 0], [0, 0]
        ]));
    }
}
