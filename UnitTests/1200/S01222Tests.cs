using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01222Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01222();
        Assert.That(sut.QueensAttacktheKing([[0, 1], [1, 0], [4, 0], [0, 4], [3, 3], [2, 4]], [0, 0]), Is.EquivalentTo((int[][]) [[0, 1], [1, 0], [3, 3]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01222();
        Assert.That(sut.QueensAttacktheKing([[0, 0], [1, 1], [2, 2], [3, 4], [3, 5], [4, 4], [4, 5]], [3, 3]), Is.EquivalentTo((int[][]) [[2, 2], [3, 4], [4, 4]]));
    }
}
