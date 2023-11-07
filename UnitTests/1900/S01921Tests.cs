using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01921Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01921();
        sut.EliminateMaximum(new[] {1, 3, 4}, new[] {1, 1, 1}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01921();
        sut.EliminateMaximum(new[] {1, 1, 2, 3}, new[] {1, 1, 1, 1}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01921();
        sut.EliminateMaximum(new[] {3, 2, 4}, new[] {5, 3, 2}).Should().Be(1);
    }
}