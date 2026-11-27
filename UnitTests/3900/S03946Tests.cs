using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03946))]
public class S03946Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03946();
        Assert.That(sut.MaximumSaleItems([[6, 2], [2, 6], [3, 4]], 9), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03946();
        Assert.That(sut.MaximumSaleItems([[2, 4], [3, 2], [4, 1], [6, 4], [12, 4]], 8), Is.EqualTo(10));
    }
}