using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01252Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01252();
        sut.OddCells(2, 3, new[] {new[] {0, 1}, new[] {1, 1}}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01252();
        sut.OddCells(2, 2, new[] {new[] {1, 1}, new[] {0, 0}}).Should().Be(0);
    }
}