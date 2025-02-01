using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01217Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01217();
        Assert.That(sut.MinCostToMoveChips(new[] {1, 2, 3}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01217();
        Assert.That(sut.MinCostToMoveChips(new[] {2, 2, 2, 3, 3}), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01217();
        Assert.That(sut.MinCostToMoveChips(new[] {1, 1000000000}), Is.EqualTo(1));
    }
}