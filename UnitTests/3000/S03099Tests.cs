using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03099Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03099();
        Assert.That(sut.SumOfTheDigitsOfHarshadNumber(18), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S03099();
        Assert.That(sut.SumOfTheDigitsOfHarshadNumber(23), Is.EqualTo(-1));
    }
}