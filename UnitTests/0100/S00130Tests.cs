using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00130Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00130();
        var board = new[]
        {
            new[] {'X', 'X', 'X', 'X'},
            new[] {'X', 'O', 'O', 'X'},
            new[] {'X', 'X', 'O', 'X'},
            new[] {'X', 'O', 'X', 'X'}
        };

        sut.Solve(board);

        Assert.That(board, Is.EquivalentTo([
            ['X', 'X', 'X', 'X'],
            ['X', 'X', 'X', 'X'],
            ['X', 'X', 'X', 'X'],
            new[] {'X', 'O', 'X', 'X'}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00130();
        var board = new[] {new[] {'X'}};
        sut.Solve(board);
        Assert.That(board, Is.EquivalentTo([new[] {'X'}]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00130();
        var board = new[]
        {
            new[] {'O', 'O', 'O'},
            new[] {'O', 'O', 'O'},
            new[] {'O', 'O', 'O'},
        };

        sut.Solve(board);

        Assert.That(board, Is.EquivalentTo([
            ['O', 'O', 'O'],
            ['O', 'O', 'O'],
            new[] {'O', 'O', 'O'}
        ]));
    }
}