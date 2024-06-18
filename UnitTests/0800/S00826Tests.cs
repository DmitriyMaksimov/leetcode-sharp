using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00826Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00826();
        sut.MaxProfitAssignment([2, 4, 6, 8, 10], [10, 20, 30, 40, 50], [4, 5, 6, 7]).Should().Be(100);
    }

    [Test]
    public void T2()
    {
        var sut = new S00826();
        sut.MaxProfitAssignment([85, 47, 57], [24, 66, 99], [40, 25, 25]).Should().Be(0);
    }
}