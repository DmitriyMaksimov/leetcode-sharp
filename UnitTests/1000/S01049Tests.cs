using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01049Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01049();
        sut.LastStoneWeightII([2, 7, 4, 1, 8, 1]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01049();
        sut.LastStoneWeightII([31, 26, 33, 21, 40]).Should().Be(5);
    }
}
