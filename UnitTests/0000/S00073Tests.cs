using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00073Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00073();
        var matrix = new[]
        {
            new[] {1, 1, 1},
            new[] {1, 0, 1},
            new[] {1, 1, 1}
        };

        sut.SetZeroes(matrix);
        matrix[0].Should().Equal(1, 0, 1);
        matrix[1].Should().Equal(0, 0, 0);
        matrix[2].Should().Equal(1, 0, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00073();
        var matrix = new[]
        {
            new[] {0, 1, 2, 0},
            new[] {3, 4, 5, 2},
            new[] {1, 3, 1, 5}
        };

        sut.SetZeroes(matrix);
        matrix[0].Should().Equal(0, 0, 0, 0);
        matrix[1].Should().Equal(0, 4, 5, 0);
        matrix[2].Should().Equal(0, 3, 1, 0);
    }
}