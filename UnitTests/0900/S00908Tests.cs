using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00908Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00908();
        sut.SmallestRangeI(new[] {1}, 0).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S00908();
        sut.SmallestRangeI(new[] {0, 10}, 2).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S00908();
        sut.SmallestRangeI(new[] {1, 3, 6}, 3).Should().Be(0);
    }
}