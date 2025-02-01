using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03372Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03372();
        Assert.That(sut.MaxTargetNodes([[0, 1], [0, 2], [2, 3], [2, 4]], [[0, 1], [0, 2], [0, 3], [2, 7], [1, 4], [4, 5], [4, 6]], 2), Is.EqualTo((int[]) [9, 7, 9, 8, 8]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03372();
        Assert.That(sut.MaxTargetNodes([[0, 1], [0, 2], [0, 3], [0, 4]], [[0, 1], [1, 2], [2, 3]], 1), Is.EqualTo((int[]) [6, 3, 3, 3, 3]));
    }
}
