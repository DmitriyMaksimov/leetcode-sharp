using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03573))]
public class S03573Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03573();
        Assert.That(sut.MaximumProfit([1, 7, 9, 8, 2], 2), Is.EqualTo(14));
    }

    [Test]
    public void T2()
    {
        var sut = new S03573();
        Assert.That(sut.MaximumProfit([12, 16, 19, 19, 8, 1, 19, 13, 9], 3), Is.EqualTo(36));
    }
}