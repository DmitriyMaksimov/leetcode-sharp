using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01716Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01716();
        Assert.That(sut.TotalMoney(4), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S01716();
        Assert.That(sut.TotalMoney(10), Is.EqualTo(37));
    }

    [Test]
    public void T3()
    {
        var sut = new S01716();
        Assert.That(sut.TotalMoney(20), Is.EqualTo(96));
    }
}