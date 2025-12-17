using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03562))]
public class S03562Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03562();
        Assert.That(sut.MaxProfit(2, [1, 2], [4, 3], [[1, 2]], 3), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03562();
        Assert.That(sut.MaxProfit(2, [3, 4], [5, 8], [[1, 2]], 4), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S03562();
        Assert.That(sut.MaxProfit(3, [4, 6, 8], [7, 9, 11], [[1, 2], [1, 3]], 10), Is.EqualTo(10));
    }

    [Test]
    public void T4()
    {
        var sut = new S03562();
        Assert.That(sut.MaxProfit(3, [5, 2, 3], [8, 5, 6], [[1, 2], [2, 3]], 7), Is.EqualTo(12));
    }
}