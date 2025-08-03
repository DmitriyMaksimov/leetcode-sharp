using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01329Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01329();
        Assert.That(sut.DiagonalSort([[3, 3, 1, 1], [2, 2, 1, 2], [1, 1, 1, 2]]), Is.EquivalentTo([
            [1, 1, 1, 1], [1, 2, 2, 2], new[] {1, 2, 3, 3}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01329();
        Assert.That(sut.DiagonalSort([
            [11, 25, 66, 1, 69, 7], [23, 55, 17, 45, 15, 52], [75, 31, 36, 44, 58, 8],
            [22, 27, 33, 25, 68, 4], [84, 28, 14, 11, 5, 50]
        ]), Is.EquivalentTo([
            [5, 17, 4, 1, 52, 7], [11, 11, 25, 45, 8, 69], [14, 23, 25, 44, 58, 15],
            [22, 27, 31, 36, 50, 66], new[] {84, 28, 75, 33, 55, 68}
        ]));
    }
}