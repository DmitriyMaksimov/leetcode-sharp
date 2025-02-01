using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00746Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00746();
        Assert.That(sut.MinCostClimbingStairs(new[] {10, 15, 20}), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S00746();
        Assert.That(sut.MinCostClimbingStairs(new[] {1, 100, 1, 1, 1, 100, 1, 1, 100, 1}), Is.EqualTo(6));
    }
}