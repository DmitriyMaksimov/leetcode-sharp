using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01514Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01514();
        sut.MaxProbability(3, new[] {new[] {0, 1}, new[] {1, 2}, new[] {0, 2}}, new[] {0.5, 0.5, 0.2}, 0, 2).Should().Be(0.25);
    }

    [Test]
    public void T2()
    {
        var sut = new S01514();
        sut.MaxProbability(3, new[] {new[] {0, 1}, new[] {1, 2}, new[] {0, 2}}, new[] {0.5, 0.5, 0.3}, 0, 2).Should().Be(0.3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01514();
        sut.MaxProbability(3, new[] {new[] {0, 1}}, new[] {0.5}, 0, 2).Should().Be(0.0);
    }
}