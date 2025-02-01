using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00240Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00240();
        var matrix = new[]
        {
            new[] {1, 4, 7, 11, 15},
            new[] {2, 5, 8, 12, 19},
            new[] {3, 6, 9, 16, 22},
            new[] {10, 13, 14, 17, 24},
            new[] {18, 21, 23, 26, 30}
        };
        Assert.That(sut.SearchMatrix(matrix, 5), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00240();
        var matrix = new[]
        {
            new[] {1, 4, 7, 11, 15},
            new[] {2, 5, 8, 12, 19},
            new[] {3, 6, 9, 16, 22},
            new[] {10, 13, 14, 17, 24},
            new[] {18, 21, 23, 26, 30}
        };
        Assert.That(sut.SearchMatrix(matrix, 20), Is.False);
    }
}
