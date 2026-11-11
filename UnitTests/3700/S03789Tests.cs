using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03789))]
public class S03789Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03789();
        Assert.That(sut.MinimumCost(3, 2, 1, 3, 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03789();
        Assert.That(sut.MinimumCost(5, 4, 15, 2, 3), Is.EqualTo(22));
    }

    [Test]
    public void T3()
    {
        var sut = new S03789();
        Assert.That(sut.MinimumCost(5, 4, 15, 0, 0), Is.Zero);
    }
}