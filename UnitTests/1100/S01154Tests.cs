using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01154Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01154();
        sut.DayOfYear("2019-01-09").Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S01154();
        sut.DayOfYear("2019-02-10").Should().Be(41);
    }
}