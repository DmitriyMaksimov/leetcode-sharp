using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03560))]
public class S03560Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03560();
        Assert.That(sut.MinCuttingCost(6, 5, 5), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03560();
        Assert.That(sut.MinCuttingCost(4, 4, 6), Is.Zero);
    }
}