using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00350Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00350();
        Assert.That(sut.Intersect([1, 2, 2, 1], [2, 2]), Is.EqualTo((int[]) [2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00350();
        Assert.That(sut.Intersect([4, 9, 5], [9, 4, 9, 8, 4]).OrderBy(x => x), Is.EqualTo((int[]) [4, 9]));
    }
}