using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02278Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02278();
        Assert.That(sut.PercentageLetter("foobar", 'o'), Is.EqualTo(33));
    }

    [Test]
    public void T2()
    {
        var sut = new S02278();
        Assert.That(sut.PercentageLetter("jjjj", 'k'), Is.EqualTo(0));
    }
}