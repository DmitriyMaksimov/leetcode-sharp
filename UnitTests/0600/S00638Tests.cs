using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00638Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00638();
        sut.ShoppingOffers([2, 5], [[3, 0, 5], [1, 2, 10]], [3, 2]).Should().Be(14);
    }

    [Test]
    public void T2()
    {
        var sut = new S00638();
        sut.ShoppingOffers([2, 3, 4], [[1, 1, 0, 4], [2, 2, 1, 9]], [1, 2, 1]).Should().Be(11);
    }
}
