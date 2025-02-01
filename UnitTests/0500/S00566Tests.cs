using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00566Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00566();
        var matrix = sut.MatrixReshape(new[] {new[] {1, 2}, new[] {3, 4}}, 1, 4);
        matrix.Should().HaveCount(1);
        Assert.That(matrix[0], Is.EqualTo((int[]) [1, 2, 3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00566();
        var matrix = sut.MatrixReshape(new[] {new[] {1, 2}, new[] {3, 4}}, 2, 4);
        matrix.Should().HaveCount(2);
        Assert.That(matrix[0], Is.EqualTo((int[]) [1, 2]));
        Assert.That(matrix[1], Is.EqualTo((int[]) [3, 4]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00566();
        var matrix = sut.MatrixReshape(new[] {new[] {1, 2}, new[] {3, 4}}, 4, 1);
        matrix.Should().HaveCount(4);
        Assert.That(matrix[0], Is.EqualTo((int[]) [1]));
        Assert.That(matrix[1], Is.EqualTo((int[]) [2]));
        Assert.That(matrix[2], Is.EqualTo((int[]) [3]));
        Assert.That(matrix[3], Is.EqualTo((int[]) [4]));
    }
}