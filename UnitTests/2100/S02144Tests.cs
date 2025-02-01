using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02144Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02144();
        Assert.That(sut.MinimumCost(new[] {1, 2, 3}), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02144();
        Assert.That(sut.MinimumCost(new[] {6, 5, 7, 9, 2, 2}), Is.EqualTo(23));
    }

    [Test]
    public void T3()
    {
        var sut = new S02144();
        Assert.That(sut.MinimumCost(new[] {5, 5}), Is.EqualTo(10));
    }
}