using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02409Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02409();
        sut.CountDaysTogether("08-15", "08-18", "08-16", "08-19").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02409();
        sut.CountDaysTogether("10-01", "10-31", "11-01", "12-31").Should().Be(0);
    }
}