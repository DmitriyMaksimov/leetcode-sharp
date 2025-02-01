using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00289Tests
{
    [Test]
    public void T1()
    {
        var board = new[]
        {
            new[] {0, 1, 0},
            new[] {0, 0, 1},
            new[] {1, 1, 1},
            new[] {0, 0, 0}
        };

        var sut = new S00289();
        sut.GameOfLife(board);

        Assert.That(board, Is.EquivalentTo(new[]
        {
            new[] {0, 0, 0},
            new[] {1, 0, 1},
            new[] {0, 1, 1},
            new[] {0, 1, 0}
        }));
    }

    [Test]
    public void T2()
    {
        var board = new[]
        {
            new[] {1, 1},
            new[] {1, 0},
        };

        var sut = new S00289();
        sut.GameOfLife(board);

        Assert.That(board, Is.EquivalentTo(new[]
        {
            new[] {1, 1},
            new[] {1, 1}
        }));
    }
}