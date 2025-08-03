using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00122Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00122();
        Assert.That(sut.MaxProfit([7, 1, 5, 3, 6, 4]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S00122();
        Assert.That(sut.MaxProfit([1, 2, 3, 4, 5]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00122();
        Assert.That(sut.MaxProfit([7, 6, 4, 3, 1]), Is.EqualTo(0));
    }
}