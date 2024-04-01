using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03099Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03099();
        sut.SumOfTheDigitsOfHarshadNumber(18).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S03099();
        sut.SumOfTheDigitsOfHarshadNumber(23).Should().Be(-1);
    }
}