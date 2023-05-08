using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01572Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01572();
        sut.DiagonalSum(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}}).Should().Be(25);
    }

    [Test]
    public void T2()
    {
        var sut = new S01572();
        sut.DiagonalSum(new[] {new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1}}).Should()
            .Be(8);
    }

    [Test]
    public void T3()
    {
        var sut = new S01572();
        sut.DiagonalSum(new[] {new[] {5}}).Should().Be(5);
    }
}