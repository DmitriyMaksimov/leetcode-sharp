using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02437Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02437();
        Assert.That(sut.CountTime("?5:00"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02437();
        Assert.That(sut.CountTime("0?:0?"), Is.EqualTo(100));
    }

    [Test]
    public void T3()
    {
        var sut = new S02437();
        Assert.That(sut.CountTime("??:??"), Is.EqualTo(1440));
    }
}