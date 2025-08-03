using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00682Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00682();
        Assert.That(sut.CalPoints(["5", "2", "C", "D", "+"]), Is.EqualTo(30));
    }

    [Test]
    public void T2()
    {
        var sut = new S00682();
        Assert.That(sut.CalPoints(["5", "-2", "4", "C", "D", "9", "+", "+"]), Is.EqualTo(27));
    }

    [Test]
    public void T3()
    {
        var sut = new S00682();
        Assert.That(sut.CalPoints(["1", "C"]), Is.EqualTo(0));
    }
}