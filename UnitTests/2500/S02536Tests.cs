using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02536Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02536();
        Assert.That(sut.RangeAddQueries(3, [[1, 1, 2, 2], [0, 0, 1, 1]]), Is.EqualTo((int[][]) [[1, 1, 0], [1, 2, 1], [0, 1, 1]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02536();
        Assert.That(sut.RangeAddQueries(2, [[0, 0, 1, 1]]), Is.EqualTo((int[][]) [[1, 1], [1, 1]]));
    }
}
