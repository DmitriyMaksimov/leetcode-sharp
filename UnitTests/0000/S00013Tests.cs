using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00013Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00013();
        Assert.That(sut.RomanToInt("III"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00013();
        Assert.That(sut.RomanToInt("LVIII"), Is.EqualTo(58));
    }

    [Test]
    public void T3()
    {
        var sut = new S00013();
        Assert.That(sut.RomanToInt("MCMXCIV"), Is.EqualTo(1994));
    }
}