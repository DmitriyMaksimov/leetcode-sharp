using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02477Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02477();
        Assert.That(sut.MinimumFuelCost([[0, 1], [0, 2], [0, 3]], 5), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02477();
        Assert.That(sut.MinimumFuelCost([
            [3, 1], [3, 2], [1, 0], [0, 4], [0, 5], [4, 6]
        ], 2), Is.EqualTo(7));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S02477();
        Assert.That(sut.MinimumFuelCost([], 1), Is.EqualTo(0));
    }
}