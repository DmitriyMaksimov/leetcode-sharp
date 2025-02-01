using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00215Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00215();
        Assert.That(sut.FindKthLargest(new[] {3, 2, 1, 5, 6, 4}, 2), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00215();
        Assert.That(sut.FindKthLargest(new[] {3, 2, 3, 1, 2, 4, 5, 5, 6}, 4), Is.EqualTo(4));
    }
}