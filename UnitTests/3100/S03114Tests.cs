using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03114Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03114();
        Assert.That(sut.FindLatestTime("1?:?4"), Is.EqualTo("11:54"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03114();
        Assert.That(sut.FindLatestTime("0?:5?"), Is.EqualTo("09:59"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03114();
        Assert.That(sut.FindLatestTime("?7:5?"), Is.EqualTo("07:59"));
    }
}