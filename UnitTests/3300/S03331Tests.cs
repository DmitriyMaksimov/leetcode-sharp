using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03331Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03331();
        Assert.That(sut.FindSubtreeSizes([-1, 0, 0, 1, 1, 1], "abaabc"), Is.EqualTo((int[]) [6, 3, 1, 1, 1, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03331();
        Assert.That(sut.FindSubtreeSizes([-1, 0, 4, 0, 1], "abbba"), Is.EqualTo((int[]) [5, 2, 1, 1, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03331();
        Assert.That(sut.FindSubtreeSizes([-1, 10, 0, 12, 10, 18, 11, 12, 2, 3, 2, 2, 2, 0, 4, 11, 4, 2, 0], "babadabbdabcbaceeda"), Is.EqualTo((int[]) [19, 1, 15, 2, 3, 1, 1, 1, 1, 1, 5, 2, 4, 1, 1, 1, 1, 1, 2]));
    }
}
