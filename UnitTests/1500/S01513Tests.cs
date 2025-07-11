using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01513))]
public class S01513Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01513();
        Assert.That(sut.NumSub("0110111"), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S01513();
        Assert.That(sut.NumSub("101"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01513();
        Assert.That(sut.NumSub("111111"), Is.EqualTo(21));
    }
}