using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02475Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02475();
        sut.UnequalTriplets(new[] {4, 4, 2, 4, 3}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02475();
        sut.UnequalTriplets(new[] {1, 1, 1, 1, 1}).Should().Be(0);
    }
}