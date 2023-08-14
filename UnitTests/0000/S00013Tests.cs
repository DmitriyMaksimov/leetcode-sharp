using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00013Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00013();
        sut.RomanToInt("III").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00013();
        sut.RomanToInt("LVIII").Should().Be(58);
    }

    [Test]
    public void T3()
    {
        var sut = new S00013();
        sut.RomanToInt("MCMXCIV").Should().Be(1994);
    }
}