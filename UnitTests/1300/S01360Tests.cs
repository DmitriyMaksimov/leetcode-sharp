using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01360Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01360();
        sut.DaysBetweenDates("2019-06-29", "2019-06-30").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01360();
        sut.DaysBetweenDates("2020-01-15", "2019-12-31").Should().Be(15);
    }
}