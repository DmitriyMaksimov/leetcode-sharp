using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01014Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01014();
        sut.MaxScoreSightseeingPair(new[] {8, 1, 5, 2, 6}).Should().Be(11);
    }

    [Test]
    public void T2()
    {
        var sut = new S01014();
        sut.MaxScoreSightseeingPair(new[] {1, 2}).Should().Be(2);
    }
}