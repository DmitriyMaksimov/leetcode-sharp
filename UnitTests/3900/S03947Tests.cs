using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03947))]
public class S03947Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03947();
        Assert.That(sut.MaximumSaleItems([[1, 6], [2, 4], [3, 5]], 19), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03947();
        Assert.That(sut.MaximumSaleItems([[2, 8], [1, 10], [6, 6], [4, 12], [5, 20], [5, 17]], 35), Is.EqualTo(7));
    }
}