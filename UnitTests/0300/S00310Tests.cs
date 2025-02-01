using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00310Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00310();
        Assert.That(sut.FindMinHeightTrees(4, [[1, 0], [1, 2], [1, 3]]), Is.EquivalentTo((int[]) [1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00310();
        Assert.That(sut.FindMinHeightTrees(6, [[3, 0], [3, 1], [3, 2], [3, 4], [5, 4]]), Is.EquivalentTo((int[]) [3, 4]));
    }
}
