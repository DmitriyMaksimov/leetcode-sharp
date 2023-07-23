using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02477Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02477();
        sut.MinimumFuelCost(new[] {new[] {0, 1}, new[] {0, 2}, new[] {0, 3}}, 5).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02477();
        sut.MinimumFuelCost(new[] {new[] {3, 1}, new[] {3, 2}, new[] {1, 0}, new[] {0, 4}, new[] {0, 5}, new[] {4, 6}}, 2).Should().Be(7);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S02477();
        sut.MinimumFuelCost(Array.Empty<int[]>(), 1).Should().Be(0);
    }
}