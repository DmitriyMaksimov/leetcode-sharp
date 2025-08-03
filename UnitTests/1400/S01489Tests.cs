using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01489Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01489();
        Assert.That(sut.FindCriticalAndPseudoCriticalEdges(5,
        [
            [0, 1, 1], [1, 2, 1], [2, 3, 2], [0, 3, 2], [0, 4, 3], [3, 4, 3],
            [1, 4, 6]
        ]), Is.EquivalentTo([[0, 1], new[] {2, 3, 4, 5}]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01489();
        Assert.That(sut.FindCriticalAndPseudoCriticalEdges(4,
        [
            [0, 1, 1], [1, 2, 1], [2, 3, 1], [0, 3, 1]
        ]), Is.EquivalentTo([[], new[] {0, 1, 2, 3}]));
    }
}