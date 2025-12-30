using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03752))]
public class S03752Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03752();
        Assert.That(sut.MaxProfit([4, 2, 8], [-1, 0, 1], 2), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S03752();
        Assert.That(sut.MaxProfit([5, 4, 3], [1, 1, 0], 2), Is.EqualTo(9));
    }
}