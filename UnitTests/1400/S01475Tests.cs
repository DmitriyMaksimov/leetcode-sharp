using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01475Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01475();
        sut.FinalPrices(new[] {8, 4, 6, 2, 3}).Should().Equal(4, 2, 4, 2, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01475();
        sut.FinalPrices(new[] {1, 2, 3, 4, 5}).Should().Equal(1, 2, 3, 4, 5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01475();
        sut.FinalPrices(new[] {10, 1, 1, 6}).Should().Equal(9, 0, 1, 6);
    }
}