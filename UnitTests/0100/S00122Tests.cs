using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00122Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00122();
        sut.MaxProfit(new[] {7, 1, 5, 3, 6, 4}).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S00122();
        sut.MaxProfit(new[] {1, 2, 3, 4, 5}).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S00122();
        sut.MaxProfit(new[] {7, 6, 4, 3, 1}).Should().Be(0);
    }
}