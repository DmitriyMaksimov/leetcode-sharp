using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03751))]
public class S03751Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03751();
        Assert.That(sut.TotalWaviness(120, 130), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03751();
        Assert.That(sut.TotalWaviness(198, 202), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03751();
        Assert.That(sut.TotalWaviness(4848, 4848), Is.EqualTo(2));
    }
}