using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01275Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01275();
        sut.Tictactoe(new[]
        {
            new[] {0, 0},
            new[] {2, 0},
            new[] {1, 1},
            new[] {2, 1},
            new[] {2, 2}
        }).Should().Be("A");
    }

    [Test]
    public void T2()
    {
        var sut = new S01275();
        sut.Tictactoe(new[]
        {
            new[] {0, 0},
            new[] {1, 1},
            new[] {0, 1},
            new[] {0, 2},
            new[] {1, 0},
            new[] {2, 0}
        }).Should().Be("B");
    }

    [Test]
    public void T3()
    {
        var sut = new S01275();
        sut.Tictactoe(new[]
        {
            new[] {0, 0},
            new[] {1, 1},
            new[] {2, 0},
            new[] {1, 0},
            new[] {1, 2},
            new[] {2, 1},
            new[] {0, 1},
            new[] {0, 2},
            new[] {2, 2}
        }).Should().Be("Draw");
    }
}