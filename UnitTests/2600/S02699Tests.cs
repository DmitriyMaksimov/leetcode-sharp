using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02699Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02699();
        sut.ModifiedGraphEdges(5, [[4, 1, -1], [2, 0, -1], [0, 3, -1], [4, 3, -1]], 0, 1, 5).Should().BeEquivalentTo([(int[]) [4, 1, 1], [2, 0, 3], [0, 3, 3], [4, 3, 1]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S02699();
        sut.ModifiedGraphEdges(3, [[0, 1, -1], [0, 2, 5]], 0, 2, 6).Should().BeEmpty();
    }

    [Test]
    public void T3()
    {
        var sut = new S02699();
        sut.ModifiedGraphEdges(4, [[1, 0, 4], [1, 2, 3], [2, 3, 5], [0, 3, -1]], 0, 2, 6).Should().BeEquivalentTo([(int[]) [1, 0, 4], [1, 2, 3], [2, 3, 5], [0, 3, 1]]);
    }
}
