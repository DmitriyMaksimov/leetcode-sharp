using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00349Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00349();
        Assert.That(sut.Intersection([1, 2, 2, 1], [2, 2]), Is.EqualTo((int[]) [2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00349();
        Assert.That(sut.Intersection([4, 9, 5], [9, 4, 9, 8, 4]).OrderBy(x => x), Is.EqualTo((int[]) [4, 9]));
    }
}