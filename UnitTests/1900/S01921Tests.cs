using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01921Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01921();
        Assert.That(sut.EliminateMaximum([1, 3, 4], [1, 1, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01921();
        Assert.That(sut.EliminateMaximum([1, 1, 2, 3], [1, 1, 1, 1]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01921();
        Assert.That(sut.EliminateMaximum([3, 2, 4], [5, 3, 2]), Is.EqualTo(1));
    }
}