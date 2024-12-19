using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01010Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01010();
        sut.NumPairsDivisibleBy60([30, 20, 150, 100, 40]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01010();
        sut.NumPairsDivisibleBy60([60, 60, 60]).Should().Be(3);
    }
}
