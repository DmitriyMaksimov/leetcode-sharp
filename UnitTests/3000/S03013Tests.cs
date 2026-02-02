using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03013))]
public class S03013Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03013();
        Assert.That(sut.MinimumCost([1, 3, 2, 6, 4, 2], 3, 3), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03013();
        Assert.That(sut.MinimumCost([10, 1, 2, 2, 2, 1], 4, 3), Is.EqualTo(15));
    }

    [Test]
    public void T3()
    {
        var sut = new S03013();
        Assert.That(sut.MinimumCost([10, 8, 18, 9], 3, 1), Is.EqualTo(36));
    }

    [Test]
    public void T4()
    {
        var sut = new S03013();
        Assert.That(
            sut.MinimumCost(
            [
                43, 44, 41, 45, 42, 41, 45, 47, 47, 50, 47, 45, 42, 42, 47, 46, 45, 50, 44, 42, 48, 46, 49, 45, 47, 47, 45, 44, 40, 42, 44, 42, 43, 46, 46, 47, 49, 44, 43, 47, 48,
                48, 41, 45, 50, 50, 44, 42, 41, 50
            ], 7, 9), Is.EqualTo(298));
    }
}