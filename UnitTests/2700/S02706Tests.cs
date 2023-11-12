using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02706Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02706();
        sut.BuyChoco(new[] {1, 2, 2}, 3).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02706();
        sut.BuyChoco(new[] {3, 2, 3}, 3).Should().Be(3);
    }
}