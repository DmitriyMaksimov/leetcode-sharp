using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02462Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02462();
        sut.TotalCost(new[] {17, 12, 10, 2, 7, 2, 11, 20, 8}, 3, 4).Should().Be(11);
    }

    [Test]
    public void T2()
    {
        var sut = new S02462();
        sut.TotalCost(new[] {1, 2, 4, 1}, 3, 3).Should().Be(4);
    }
}