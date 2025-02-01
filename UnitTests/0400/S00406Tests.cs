using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00406Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00406();
        Assert.That(sut.ReconstructQueue([[7, 0], [4, 4], [7, 1], [5, 0], [6, 1], [5, 2]]), Is.EquivalentTo((int[][]) [[5, 0], [7, 0], [5, 2], [6, 1], [4, 4], [7, 1]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00406();
        Assert.That(sut.ReconstructQueue([[6, 0], [5, 0], [4, 0], [3, 2], [2, 2], [1, 4]]), Is.EquivalentTo((int[][]) [[4, 0], [5, 0], [2, 2], [3, 2], [1, 4], [6, 0]]));
    }
}
