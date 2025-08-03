using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01275Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01275();
        Assert.That(sut.Tictactoe([
            [0, 0],
            [2, 0],
            [1, 1],
            [2, 1],
            [2, 2]
        ]), Is.EqualTo("A"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01275();
        Assert.That(sut.Tictactoe([
            [0, 0],
            [1, 1],
            [0, 1],
            [0, 2],
            [1, 0],
            [2, 0]
        ]), Is.EqualTo("B"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01275();
        Assert.That(sut.Tictactoe([
            [0, 0],
            [1, 1],
            [2, 0],
            [1, 0],
            [1, 2],
            [2, 1],
            [0, 1],
            [0, 2],
            [2, 2]
        ]), Is.EqualTo("Draw"));
    }
}