using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00592Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00592();
        sut.FractionAddition("-1/2+1/2").Should().Be("0/1");
    }

    [Test]
    public void T2()
    {
        var sut = new S00592();
        sut.FractionAddition("-1/2+1/2+1/3").Should().Be("1/3");
    }

    [Test]
    public void T3()
    {
        var sut = new S00592();
        sut.FractionAddition("1/3-1/2").Should().Be("-1/6");
    }
}
