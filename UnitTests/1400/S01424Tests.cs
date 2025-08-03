using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01424Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01424();
        Assert.That(sut.FindDiagonalOrder([[1, 2, 3], [4, 5, 6], [7, 8, 9]]), Is.EqualTo((int[]) [1, 4, 2, 7, 5, 3, 8, 6, 9]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01424();
        Assert.That(sut.FindDiagonalOrder([
            [1, 2, 3, 4, 5], [6, 7], [8], [9, 10, 11], [12, 13, 14, 15, 16]
        ]), Is.EqualTo((int[]) [1, 6, 2, 8, 7, 3, 9, 4, 12, 10, 5, 13, 11, 14, 15, 16]));
    }
}