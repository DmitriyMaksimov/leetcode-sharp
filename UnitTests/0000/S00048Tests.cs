using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00048Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00048();
        var matrix = new[]
        {
            new[] {1, 2, 3},
            new[] {4, 5, 6},
            new[] {7, 8, 9}
        };
        sut.Rotate(matrix);
        Assert.That(matrix[0], Is.EqualTo((int[]) [7, 4, 1]));
        Assert.That(matrix[1], Is.EqualTo((int[]) [8, 5, 2]));
        Assert.That(matrix[2], Is.EqualTo((int[]) [9, 6, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00048();
        var matrix = new[]
        {
            new[] {5, 1, 9, 11},
            new[] {2, 4, 8, 10},
            new[] {13, 3, 6, 7},
            new[] {15, 14, 12, 16}
        };
        sut.Rotate(matrix);
        Assert.That(matrix[0], Is.EqualTo((int[]) [15, 13, 2, 5]));
        Assert.That(matrix[1], Is.EqualTo((int[]) [14, 3, 4, 1]));
        Assert.That(matrix[2], Is.EqualTo((int[]) [12, 6, 8, 9]));
        Assert.That(matrix[3], Is.EqualTo((int[]) [16, 7, 10, 11]));
    }
}