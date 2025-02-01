using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02948Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02948();
        Assert.That(sut.LexicographicallySmallestArray([1, 5, 3, 9, 8], 2), Is.EqualTo((int[]) [1, 3, 5, 8, 9]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02948();
        Assert.That(sut.LexicographicallySmallestArray([1, 7, 6, 18, 2, 1], 3), Is.EqualTo((int[]) [1, 6, 7, 18, 1, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02948();
        Assert.That(sut.LexicographicallySmallestArray([1, 7, 28, 19, 10], 3), Is.EqualTo((int[]) [1, 7, 28, 19, 10]));
    }
}
