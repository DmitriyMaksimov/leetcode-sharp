using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02315Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02315();
        sut.CountAsterisks("l|*e*et|c**o|*de|").Should().Be(2);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02315();
        sut.CountAsterisks("iamprogrammer").Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02315();
        sut.CountAsterisks("yo|uar|e**|b|e***au|tifu|l").Should().Be(5);
    }
}