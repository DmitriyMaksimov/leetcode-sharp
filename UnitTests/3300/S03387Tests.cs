using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03387Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03387();
        Assert.That(sut.MaxAmount("EUR", [["EUR", "USD"], ["USD", "JPY"]], [2.0, 3.0], [["JPY", "USD"], ["USD", "CHF"], ["CHF", "EUR"]], [4.0, 5.0, 6.0]), Is.EqualTo(720).Within(0.00001));
    }

    [Test]
    public void T2()
    {
        var sut = new S03387();
        Assert.That(sut.MaxAmount("NGN", [["NGN", "EUR"]], [9.0], [["NGN", "EUR"]], [6.0]), Is.EqualTo(1.5).Within(0.00001));
    }

    [Test]
    public void T3()
    {
        var sut = new S03387();
        Assert.That(sut.MaxAmount("USD", [["USD", "EUR"]], [1.0], [["EUR", "JPY"]], [10.0]), Is.EqualTo(1).Within(0.00001));
    }
}
