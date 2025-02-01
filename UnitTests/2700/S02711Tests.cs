using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02711Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02711();
        Assert.That(sut.DifferenceOfDistinctValues([[1, 2, 3], [3, 1, 5], [3, 2, 1]]), Is.EquivalentTo((int[][]) [[1, 1, 0], [1, 0, 1], [0, 1, 1]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02711();
        Assert.That(sut.DifferenceOfDistinctValues([[1]]), Is.EquivalentTo((int[][]) [[0]]));
    }
}
