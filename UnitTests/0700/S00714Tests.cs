using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00714Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00714();
        sut.MaxProfit(new[] {1, 3, 2, 8, 4, 9}, 2).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S00714();
        sut.MaxProfit(new[] {1, 3, 7, 5, 10, 3}, 3).Should().Be(6);
    }
}