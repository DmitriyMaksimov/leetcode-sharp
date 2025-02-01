using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01227Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01227();
        Assert.That(sut.NthPersonGetsNthSeat(1), Is.EqualTo(1.0));
    }

    [Test]
    public void T2()
    {
        var sut = new S01227();
        Assert.That(sut.NthPersonGetsNthSeat(2), Is.EqualTo(0.5));
    }
}
