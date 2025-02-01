using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02315Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02315();
        Assert.That(sut.CountAsterisks("l|*e*et|c**o|*de|"), Is.EqualTo(2));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02315();
        Assert.That(sut.CountAsterisks("iamprogrammer"), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02315();
        Assert.That(sut.CountAsterisks("yo|uar|e**|b|e***au|tifu|l"), Is.EqualTo(5));
    }
}