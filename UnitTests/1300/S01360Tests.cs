using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01360Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01360();
        Assert.That(sut.DaysBetweenDates("2019-06-29", "2019-06-30"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01360();
        Assert.That(sut.DaysBetweenDates("2020-01-15", "2019-12-31"), Is.EqualTo(15));
    }
}