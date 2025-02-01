using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00786Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00786();
        Assert.That(sut.KthSmallestPrimeFraction([1, 2, 3, 5], 3), Is.EquivalentTo((int[]) [2, 5]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00786();
        Assert.That(sut.KthSmallestPrimeFraction([1, 7], 1), Is.EquivalentTo((int[]) [1, 7]));
    }
}
