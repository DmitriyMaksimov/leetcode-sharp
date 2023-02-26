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
        matrix[0].Should().Equal(1, 2, 3, 4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00566();
        var matrix = sut.MatrixReshape(new[] {new[] {1, 2}, new[] {3, 4}}, 2, 4);
        matrix.Should().HaveCount(2);
        matrix[0].Should().Equal(1, 2);
        matrix[1].Should().Equal(3, 4);
    }

    [Test]
    public void T3()
    {
        var sut = new S00566();
        var matrix = sut.MatrixReshape(new[] {new[] {1, 2}, new[] {3, 4}}, 4, 1);
        matrix.Should().HaveCount(4);
        matrix[0].Should().Equal(1);
        matrix[1].Should().Equal(2);
        matrix[2].Should().Equal(3);
        matrix[3].Should().Equal(4);
    }
}