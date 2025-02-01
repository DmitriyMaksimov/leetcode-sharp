using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01154Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01154();
        Assert.That(sut.DayOfYear("2019-01-09"), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S01154();
        Assert.That(sut.DayOfYear("2019-02-10"), Is.EqualTo(41));
    }
}