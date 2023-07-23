using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01402Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01402();
        sut.MaxSatisfaction(new[] {-1, -8, 0, 5, -9}).Should().Be(14);
    }

    [Test]
    public void T2()
    {
        var sut = new S01402();
        sut.MaxSatisfaction(new[] {4, 3, 2}).Should().Be(20);
    }

    [Test]
    public void T3()
    {
        var sut = new S01402();
        sut.MaxSatisfaction(new[] {-1, -4, -5}).Should().Be(0);
    }
}