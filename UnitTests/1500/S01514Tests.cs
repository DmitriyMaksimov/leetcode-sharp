using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01514Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01514();
        Assert.That(sut.MaxProbability(3, [[0, 1], [1, 2], [0, 2]], [0.5, 0.5, 0.2], 0, 2), Is.EqualTo(0.25));
    }

    [Test]
    public void T2()
    {
        var sut = new S01514();
        Assert.That(sut.MaxProbability(3, [[0, 1], [1, 2], [0, 2]], [0.5, 0.5, 0.3], 0, 2), Is.EqualTo(0.3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01514();
        Assert.That(sut.MaxProbability(3, [[0, 1]], [0.5], 0, 2), Is.EqualTo(0.0));
    }
}