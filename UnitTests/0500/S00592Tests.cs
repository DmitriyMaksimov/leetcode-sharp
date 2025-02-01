using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00592Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00592();
        Assert.That(sut.FractionAddition("-1/2+1/2"), Is.EqualTo("0/1"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00592();
        Assert.That(sut.FractionAddition("-1/2+1/2+1/3"), Is.EqualTo("1/3"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00592();
        Assert.That(sut.FractionAddition("1/3-1/2"), Is.EqualTo("-1/6"));
    }
}
