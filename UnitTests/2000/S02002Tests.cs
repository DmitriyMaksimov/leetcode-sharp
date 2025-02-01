using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02002Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02002();
        Assert.That(sut.MaxProduct("leetcodecom"), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S02002();
        Assert.That(sut.MaxProduct("bb"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02002();
        Assert.That(sut.MaxProduct("accbcaxxcxx"), Is.EqualTo(25));
    }
}
