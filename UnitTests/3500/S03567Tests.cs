using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03567))]
public class S03567Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03567();
        Assert.That(sut.MinAbsDiff([[1, 8], [3, -2]], 2), Is.EqualTo((int[][]) [[2]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03567();
        Assert.That(sut.MinAbsDiff([[3, -1]], 1), Is.EqualTo((int[][]) [[0, 0]]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03567();
        Assert.That(sut.MinAbsDiff([[1, -2, 3], [2, 3, 5]], 2), Is.EqualTo((int[][]) [[1, 2]]));
    }
}
