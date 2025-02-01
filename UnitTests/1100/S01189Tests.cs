using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01189Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01189();
        Assert.That(sut.MaxNumberOfBalloons("nlaebolko"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01189();
        Assert.That(sut.MaxNumberOfBalloons("loonbalxballpoon"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01189();
        Assert.That(sut.MaxNumberOfBalloons("leetcode"), Is.EqualTo(0));
    }
}