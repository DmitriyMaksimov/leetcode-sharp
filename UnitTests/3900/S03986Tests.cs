using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03986))]
public class S03986Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03986();
        Assert.That(sut.SecondsBetweenTimes("01:00:00", "01:00:25"), Is.EqualTo(25));
    }

    [Test]
    public void T2()
    {
        var sut = new S03986();
        Assert.That(sut.SecondsBetweenTimes("12:34:56", "13:00:00"), Is.EqualTo(1504));
    }
}