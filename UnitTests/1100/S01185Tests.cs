using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01185Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01185();
        sut.DayOfTheWeek(31, 8, 2019).Should().Be("Saturday");
    }

    [Test]
    public void T2()
    {
        var sut = new S01185();
        sut.DayOfTheWeek(18, 7, 1999).Should().Be("Sunday");
    }

    [Test]
    public void T3()
    {
        var sut = new S01185();
        sut.DayOfTheWeek(15, 8, 1993).Should().Be("Sunday");
    }
}