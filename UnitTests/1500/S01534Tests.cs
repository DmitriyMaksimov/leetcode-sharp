using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01534Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01534();
        sut.CountGoodTriplets(new[] {3, 0, 1, 1, 9, 7}, 7, 2, 3).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01534();
        sut.CountGoodTriplets(new[] {1, 1, 2, 2, 3}, 0, 0, 1).Should().Be(0);
    }
}