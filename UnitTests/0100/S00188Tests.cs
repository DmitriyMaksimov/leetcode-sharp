using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00188Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00188();
        Assert.That(sut.MaxProfit(2, new[] {2, 4, 1}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00188();
        Assert.That(sut.MaxProfit(2, new[] {3, 2, 6, 5, 0, 3}), Is.EqualTo(7));
    }
}