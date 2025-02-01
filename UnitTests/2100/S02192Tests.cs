using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02192Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02192();
        Assert.That(sut.GetAncestors(5, [[0, 1], [0, 2], [0, 3], [0, 4], [1, 2], [1, 3], [1, 4], [2, 3], [2, 4], [3, 4]]), Is.EquivalentTo((int[][]) [[], [0], [0, 1], [0, 1, 2], [0, 1, 2, 3]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02192();
        Assert.That(sut.GetAncestors(8, [[0, 3], [0, 4], [1, 3], [2, 4], [2, 7], [3, 5], [3, 6], [3, 7], [4, 6]]), Is.EquivalentTo(
            (int[][]) [[], [], [], [0, 1], [0, 2], [0, 1, 3], [0, 1, 2, 3, 4], [0, 1, 2, 3]]));
    }
}
