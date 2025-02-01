using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00121Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00121();
        Assert.That(sut.MaxProfit(new[] {7, 1, 5, 3, 6, 4}), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00121();
        Assert.That(sut.MaxProfit(new[] {7, 6, 4, 3, 1}), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00121();
        Assert.That(sut.MaxProfit(Array.Empty<int>()), Is.EqualTo(0));
    }
}