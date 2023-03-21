using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01162Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01162();
        sut.MaxDistance(new[] {new[] {1, 0, 1}, new[] {0, 0, 0}, new[] {1, 0, 1}}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01162();
        sut.MaxDistance(new[] {new[] {1, 0, 0}, new[] {0, 0, 0}, new[] {0, 0, 0}}).Should().Be(4);
    }
}