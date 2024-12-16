using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03387Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03387();
        sut.MaxAmount("EUR", [["EUR", "USD"], ["USD", "JPY"]], [2.0, 3.0], [["JPY", "USD"], ["USD", "CHF"], ["CHF", "EUR"]], [4.0, 5.0, 6.0]).Should()
            .BeApproximately(720, 0.00001);
    }

    [Test]
    public void T2()
    {
        var sut = new S03387();
        sut.MaxAmount("NGN", [["NGN", "EUR"]], [9.0], [["NGN", "EUR"]], [6.0]).Should().BeApproximately(1.5, 0.00001);
    }

    [Test]
    public void T3()
    {
        var sut = new S03387();
        sut.MaxAmount("USD", [["USD", "EUR"]], [1.0], [["EUR", "JPY"]], [10.0]).Should().BeApproximately(1, 0.00001);
    }
}
