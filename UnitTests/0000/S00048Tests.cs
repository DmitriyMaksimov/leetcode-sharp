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
        matrix[0].Should().Equal(7, 4, 1);
        matrix[1].Should().Equal(8, 5, 2);
        matrix[2].Should().Equal(9, 6, 3);
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
        matrix[0].Should().Equal(15, 13, 2, 5);
        matrix[1].Should().Equal(14, 3, 4, 1);
        matrix[2].Should().Equal(12, 6, 8, 9);
        matrix[3].Should().Equal(16, 7, 10, 11);
    }
}