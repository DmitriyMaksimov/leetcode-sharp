using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01751Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01751();
        sut.MaxValue(new[] {new[] {1, 2, 4}, new[] {3, 4, 3}, new[] {2, 3, 1}}, 2).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S01751();
        sut.MaxValue(new[] {new[] {1, 2, 4}, new[] {3, 4, 3}, new[] {2, 3, 10}}, 2).Should().Be(10);
    }

    [Test]
    public void T3()
    {
        var sut = new S01751();
        sut.MaxValue(new[] {new[] {1, 1, 1}, new[] {2, 2, 2}, new[] {3, 3, 3}, new[] {4, 4, 4}}, 3).Should().Be(9);
    }
}