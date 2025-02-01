using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01475Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01475();
        Assert.That(sut.FinalPrices(new[] {8, 4, 6, 2, 3}), Is.EqualTo((int[]) [4, 2, 4, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01475();
        Assert.That(sut.FinalPrices(new[] {1, 2, 3, 4, 5}), Is.EqualTo((int[]) [1, 2, 3, 4, 5]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01475();
        Assert.That(sut.FinalPrices(new[] {10, 1, 1, 6}), Is.EqualTo((int[]) [9, 0, 1, 6]));
    }
}